using Painter.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Painter
{
	public partial class frmMain : Form
	{
		Bitmap bitmap;
		Point start, end;
		string[] classNames;    // All classes of DLL files
		int selectedShape = 0;
		Assembly assembly;

		AppConfig appConfig;
		public frmMain()
		{
			InitializeComponent();
			LoadConfig();
			this.Text = appConfig.Title;
			this.Width = appConfig.Width;
			this.Height = appConfig.Height;
			Trace.WriteLine("Form is loaded");
			bitmap = new Bitmap(container.Width, container.Height);
		}

		private void ButtonOfFlowPanel_Click(object sender, EventArgs e)
		{
			var button = sender as Button;
			this.selectedShape = flowLayout.Controls.IndexOf(button);
		}

		private void btnColor_Click(object sender, EventArgs e)
		{
			colorDialog.ShowDialog();
		}

		private void container_MouseDown(object sender, MouseEventArgs e)
		{
			start = new Point(e.X, e.Y);
			Trace.WriteLine($"Mouse down at [{e.X};{e.Y}]");
		}

		private void container_MouseUp(object sender, MouseEventArgs e)
		{
			end = new Point(e.X, e.Y);
			Trace.WriteLine($"Mouse up at [{e.X};{e.Y}]");
			this.Draw();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			var g1 = container.CreateGraphics();
			g1.Clear(Color.White);
			var g2 = Graphics.FromImage(bitmap);
			g2.Clear(Color.White);
		}

		private void loadDllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadDLLFile.InitialDirectory = this.GetCurrentProjectPath();
			loadDLLFile.ShowDialog();
		}

		private void loadDLLFile_FileOk(object sender, CancelEventArgs e)
		{
			this.assembly = Assembly.LoadFrom(loadDLLFile.FileName);
			// Get all class of Shapes, using LinQ
			this.classNames = assembly
								.GetTypes()
								.Where(n => n.IsClass && !n.IsAbstract) //Lamda Expression
								.Select(x => x.FullName)
								.ToArray();
			RemoveControlFromListView();
			AddControlToListView();
			btnClear_Click(btnClear, null);
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show(appConfig.About, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void saveAsxmlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFile.InitialDirectory = this.GetCurrentProjectPath();
			saveFile.ShowDialog();
		}

		private void saveFile_FileOk(object sender, CancelEventArgs e)
		{
			try
			{
				// Convert to Base64
				MemoryStream ms = new MemoryStream();
				bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
				var bytes = ms.ToArray();
				var base64 = Convert.ToBase64String(bytes);

				// Save to XML file
				XmlWriter xmlWriter = XmlWriter.Create(saveFile.FileName);
				xmlWriter.WriteStartElement("picture");
				xmlWriter.WriteString(base64);
				xmlWriter.WriteEndElement();
				xmlWriter.Flush();
				Trace.Write(saveFile.FileName);
				saveFile.FileName = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Debug.WriteLine(ex.Message);
				Debug.WriteLine(ex.StackTrace);
			}
		}

		private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openXMLFile.FileName = "";
			openXMLFile.InitialDirectory = this.GetCurrentProjectPath();
			openXMLFile.ShowDialog();
		}

		private void openXMLFile_FileOk(object sender, CancelEventArgs e)
		{
			try
			{
				// Load bitmap from xml file
				var xml = new XmlDocument();
				xml.Load(openXMLFile.FileName);
				var rootNode = xml.SelectSingleNode("picture");
				var base64 = rootNode.InnerText;
				var bytes = Convert.FromBase64String(base64);
				MemoryStream ms = new MemoryStream(bytes);
				ms.Position = 0;
				bitmap = (Bitmap)Bitmap.FromStream(ms);
				ms.Close();
				ms.Dispose();

				// Show bitmap
				var g = container.CreateGraphics();
				g.DrawImage(bitmap, 0, 0);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Debug.WriteLine(ex.Message);
				Debug.WriteLine(ex.StackTrace);
			}
		}

		private void Draw()
		{
			if (this.assembly == null)
			{
				return;
			}
			if (selectedShape >= classNames.Length)
			{
				selectedShape = 0;
			}
			var g1 = container.CreateGraphics();
			var g2 = Graphics.FromImage(bitmap);
			// Reflection
			Type type = this.assembly.GetType(classNames[selectedShape]);
			ConstructorInfo ctor = type.GetConstructor(new[] {
				start.GetType(),
				end.GetType(),
				typeof(Color)
			});
			// Call constructor using reflection
			object shape = ctor.Invoke(new object[] {
				start,
				end,
				colorDialog.Color });
			// Call method [Draw] using reflection
			type.GetMethod("Draw").Invoke(shape, new object[] { g1 });
			type.GetMethod("Draw").Invoke(shape, new object[] { g2 });
			Trace.WriteLine($"Drew a shape from {classNames[selectedShape]}");
		}

		private void RemoveControlFromListView()
		{
			flowLayout.Controls.Clear();
		}

		private void AddControlToListView()
		{
			var i = 0;
			foreach (var name in this.classNames)
			{
				var btn = new Button
				{
					Text = name.Split('.').Last(),
					Height = 32,
					Width = 95,
					TabIndex = i++
				};
				btn.Click += ButtonOfFlowPanel_Click;
				flowLayout.Controls.Add(btn);
			}
		}

		private void LoadConfig()
		{
			try
			{
				var xml = new XmlDocument();
				xml.Load("config.xml");
				this.appConfig = new AppConfig();
				var rootNode = xml.SelectSingleNode("appConfig");
				appConfig.Title = rootNode.SelectSingleNode("title")?.InnerText;
				appConfig.Width = Convert.ToInt32(rootNode.SelectSingleNode("width")?.InnerText);
				appConfig.Height = Convert.ToInt32(rootNode.SelectSingleNode("height")?.InnerText);
				appConfig.About = rootNode.SelectSingleNode("about")?.InnerText;
			}
			catch(Exception ex)
			{
				appConfig.Title = this.Text;
				appConfig.Width = this.Width;
				appConfig.Height = this.Height;
				appConfig.About = "Something was wrong!";
				Debug.WriteLine(ex.Message);
				Debug.WriteLine(ex.StackTrace);
			}
		}

        private void saveAsJPG_Click(object sender, EventArgs e)
        {
			try
			{

				SaveFileDialog sf = new SaveFileDialog();
				sf.Filter = "JPG(*.JPG)|*.jpg";
				if (sf.ShowDialog() == DialogResult.OK)
				{
					bitmap.Save(sf.FileName);
				}
				Trace.Write(saveFile.FileName);
				saveFile.FileName = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Debug.WriteLine(ex.Message);
				Debug.WriteLine(ex.StackTrace);
			}

        }

        private string GetCurrentProjectPath()
		{
			var currentDir = Directory.GetCurrentDirectory();
			var folders = currentDir.Split('\\').ToList();
			if (folders.Count > 3)
			{
				folders.RemoveAt(folders.Count - 1);
				folders.RemoveAt(folders.Count - 1);
				folders.RemoveAt(folders.Count - 1);
			}
			return String.Join("\\", folders);
		}
	}
}
