using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace HREF_Reference_File_Renamer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Main_Form : System.Windows.Forms.Form
	{
		private System.Windows.Forms.OpenFileDialog Dialog_openWebPageDialog;
		private System.Windows.Forms.OpenFileDialog Dialog_openFolderDialog;
		private System.Windows.Forms.Button Button_OpenWebPageDialog;
		private System.Windows.Forms.Label Label_Selected_WebPage;
		private System.Windows.Forms.Button Button_OpenFolderDialog;
		private System.Windows.Forms.Label Label_Selected_Folder;
		private System.Windows.Forms.Button Button_Process_Files;
		private System.Windows.Forms.TextBox TextBox_Processed_Files;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Main_Form()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Dialog_openWebPageDialog = new System.Windows.Forms.OpenFileDialog();
			this.Dialog_openFolderDialog = new System.Windows.Forms.OpenFileDialog();
			this.Button_OpenWebPageDialog = new System.Windows.Forms.Button();
			this.Label_Selected_WebPage = new System.Windows.Forms.Label();
			this.Button_OpenFolderDialog = new System.Windows.Forms.Button();
			this.Label_Selected_Folder = new System.Windows.Forms.Label();
			this.Button_Process_Files = new System.Windows.Forms.Button();
			this.TextBox_Processed_Files = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Button_OpenWebPageDialog
			// 
			this.Button_OpenWebPageDialog.Location = new System.Drawing.Point(16, 16);
			this.Button_OpenWebPageDialog.Name = "Button_OpenWebPageDialog";
			this.Button_OpenWebPageDialog.Size = new System.Drawing.Size(104, 23);
			this.Button_OpenWebPageDialog.TabIndex = 0;
			this.Button_OpenWebPageDialog.Text = "Select Web Page";
			this.Button_OpenWebPageDialog.Click += new System.EventHandler(this.Button_OpenWebPageDialog_Click);
			// 
			// Label_Selected_WebPage
			// 
			this.Label_Selected_WebPage.Location = new System.Drawing.Point(16, 48);
			this.Label_Selected_WebPage.Name = "Label_Selected_WebPage";
			this.Label_Selected_WebPage.Size = new System.Drawing.Size(264, 23);
			this.Label_Selected_WebPage.TabIndex = 1;
			// 
			// Button_OpenFolderDialog
			// 
			this.Button_OpenFolderDialog.Location = new System.Drawing.Point(16, 72);
			this.Button_OpenFolderDialog.Name = "Button_OpenFolderDialog";
			this.Button_OpenFolderDialog.Size = new System.Drawing.Size(104, 23);
			this.Button_OpenFolderDialog.TabIndex = 2;
			this.Button_OpenFolderDialog.Text = "Select Folder";
			this.Button_OpenFolderDialog.Click += new System.EventHandler(this.Button_OpenFolderDialog_Click);
			// 
			// Label_Selected_Folder
			// 
			this.Label_Selected_Folder.Location = new System.Drawing.Point(16, 104);
			this.Label_Selected_Folder.Name = "Label_Selected_Folder";
			this.Label_Selected_Folder.Size = new System.Drawing.Size(264, 23);
			this.Label_Selected_Folder.TabIndex = 3;
			// 
			// Button_Process_Files
			// 
			this.Button_Process_Files.Enabled = false;
			this.Button_Process_Files.Location = new System.Drawing.Point(16, 128);
			this.Button_Process_Files.Name = "Button_Process_Files";
			this.Button_Process_Files.Size = new System.Drawing.Size(104, 23);
			this.Button_Process_Files.TabIndex = 4;
			this.Button_Process_Files.Text = "Process";
			// 
			// TextBox_Processed_Files
			// 
			this.TextBox_Processed_Files.Location = new System.Drawing.Point(16, 168);
			this.TextBox_Processed_Files.Multiline = true;
			this.TextBox_Processed_Files.Name = "TextBox_Processed_Files";
			this.TextBox_Processed_Files.Size = new System.Drawing.Size(256, 88);
			this.TextBox_Processed_Files.TabIndex = 5;
			this.TextBox_Processed_Files.Text = "";
			// 
			// Main_Form
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.TextBox_Processed_Files,
																		  this.Button_Process_Files,
																		  this.Label_Selected_Folder,
																		  this.Button_OpenFolderDialog,
																		  this.Label_Selected_WebPage,
																		  this.Button_OpenWebPageDialog});
			this.Name = "Main_Form";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Button_OpenWebPageDialog_Click(object sender, System.EventArgs e)
		{
			Dialog_openWebPageDialog.ShowDialog();
			if (Dialog_openWebPageDialog.FileOk == true)
			{
				Label_Selected_WebPage.Text = Dialog_openWebPageDialog.FileName;
			}
		}

		private void Button_OpenFolderDialog_Click(object sender, System.EventArgs e)
		{
			Dialog_openFolderDialog.ShowDialog();
			if (Dialog_openFolderDialog.FileOk == true)
			{
				Label_Selected_WebPage.Text = Dialog_openWebPageDialog.FileName;
			}		
		}


	}
}
