using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace HREF_Reference_File_Renamer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	/// 


	public class Main_Form : System.Windows.Forms.Form
	{
		private System.Windows.Forms.OpenFileDialog Dialog_openWebPageDialog;
		private System.Windows.Forms.OpenFileDialog Dialog_openFolderDialog;
		private System.Windows.Forms.Button Button_OpenWebPageDialog;
		private System.Windows.Forms.Label Label_Selected_WebPage;
		private System.Windows.Forms.Button Button_OpenFolderDialog;
		private System.Windows.Forms.Label Label_Selected_Folder;
		private System.Windows.Forms.Button Button_Process_Files;
		private System.Windows.Forms.StatusBar StatusBar_Main;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button Button_Rename_Files;
		private System.Windows.Forms.CheckBox CheckBox_Create_Folders;
		private System.Windows.Forms.DataGrid DataGrid_Processed_Files;
		private System.Data.DataSet DataSet_Processed_Files;
		private System.Data.DataTable DataTable_Processed_Files;
		private System.Data.DataColumn DataColumn_Filename;
		private System.Data.DataColumn DataColumn_Description;
		private System.Data.DataColumn DataColumn_Extension;
		private System.Data.DataColumn dataColumn1;
		private System.Windows.Forms.GroupBox GroupBox_Processed_Files;
		private System.Data.DataColumn dataColumn2;
		private System.Windows.Forms.DataGrid DataGrid_Renamed_Files;
		private System.Windows.Forms.DataGridTableStyle Style_Renamed_Files;
		private System.Windows.Forms.DataGridTextBoxColumn Filename;
		private System.Windows.Forms.DataGridTextBoxColumn Description;
		private System.Windows.Forms.DataGridTextBoxColumn Reason;
		private System.Windows.Forms.DataGridTextBoxColumn ID;
		private System.Windows.Forms.DataGridTextBoxColumn Result;
		private System.Windows.Forms.DataGridTableStyle Style_Processed_Files;
		private System.Windows.Forms.DataGridTextBoxColumn Filename_P;
		private System.Windows.Forms.DataGridTextBoxColumn Description_P;
		private System.Windows.Forms.DataGridTextBoxColumn Extension_P;
		private System.Windows.Forms.DataGridTextBoxColumn ID_P;
		private System.Windows.Forms.ContextMenu ContextMenu_DataGrid_Renamed_Files;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Data.DataColumn dataColumn3;

		public Main_Form()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Main_Form));
			this.Dialog_openWebPageDialog = new System.Windows.Forms.OpenFileDialog();
			this.Dialog_openFolderDialog = new System.Windows.Forms.OpenFileDialog();
			this.Button_OpenWebPageDialog = new System.Windows.Forms.Button();
			this.Label_Selected_WebPage = new System.Windows.Forms.Label();
			this.Button_OpenFolderDialog = new System.Windows.Forms.Button();
			this.Label_Selected_Folder = new System.Windows.Forms.Label();
			this.Button_Process_Files = new System.Windows.Forms.Button();
			this.StatusBar_Main = new System.Windows.Forms.StatusBar();
			this.Button_Rename_Files = new System.Windows.Forms.Button();
			this.CheckBox_Create_Folders = new System.Windows.Forms.CheckBox();
			this.DataGrid_Processed_Files = new System.Windows.Forms.DataGrid();
			this.DataSet_Processed_Files = new System.Data.DataSet();
			this.DataTable_Processed_Files = new System.Data.DataTable();
			this.DataColumn_Filename = new System.Data.DataColumn();
			this.DataColumn_Description = new System.Data.DataColumn();
			this.DataColumn_Extension = new System.Data.DataColumn();
			this.dataColumn1 = new System.Data.DataColumn();
			this.dataColumn2 = new System.Data.DataColumn();
			this.dataColumn3 = new System.Data.DataColumn();
			this.Style_Processed_Files = new System.Windows.Forms.DataGridTableStyle();
			this.Filename_P = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Description_P = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Extension_P = new System.Windows.Forms.DataGridTextBoxColumn();
			this.ID_P = new System.Windows.Forms.DataGridTextBoxColumn();
			this.GroupBox_Processed_Files = new System.Windows.Forms.GroupBox();
			this.DataGrid_Renamed_Files = new System.Windows.Forms.DataGrid();
			this.ContextMenu_DataGrid_Renamed_Files = new System.Windows.Forms.ContextMenu();
			this.Style_Renamed_Files = new System.Windows.Forms.DataGridTableStyle();
			this.Result = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Filename = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Reason = new System.Windows.Forms.DataGridTextBoxColumn();
			this.ID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DataGrid_Processed_Files)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataSet_Processed_Files)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataTable_Processed_Files)).BeginInit();
			this.GroupBox_Processed_Files.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGrid_Renamed_Files)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// Dialog_openWebPageDialog
			// 
			this.Dialog_openWebPageDialog.DefaultExt = "htm";
			this.Dialog_openWebPageDialog.Filter = "All files|*.*|HTML|*.html|HTM|*.htm|ASP|*.asp";
			this.Dialog_openWebPageDialog.FilterIndex = 3;
			this.Dialog_openWebPageDialog.Title = "Select Webpage to be processed";
			// 
			// Dialog_openFolderDialog
			// 
			this.Dialog_openFolderDialog.AddExtension = false;
			this.Dialog_openFolderDialog.Filter = "All files|*.*";
			this.Dialog_openFolderDialog.Title = "Select a file in the Folder to be processed";
			// 
			// Button_OpenWebPageDialog
			// 
			this.Button_OpenWebPageDialog.BackColor = System.Drawing.Color.LightGray;
			this.Button_OpenWebPageDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button_OpenWebPageDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Button_OpenWebPageDialog.ForeColor = System.Drawing.Color.Red;
			this.Button_OpenWebPageDialog.Location = new System.Drawing.Point(16, 16);
			this.Button_OpenWebPageDialog.Name = "Button_OpenWebPageDialog";
			this.Button_OpenWebPageDialog.Size = new System.Drawing.Size(112, 23);
			this.Button_OpenWebPageDialog.TabIndex = 0;
			this.Button_OpenWebPageDialog.Text = "Select Web Page";
			this.Button_OpenWebPageDialog.Click += new System.EventHandler(this.Button_OpenWebPageDialog_Click);
			// 
			// Label_Selected_WebPage
			// 
			this.Label_Selected_WebPage.BackColor = System.Drawing.Color.Transparent;
			this.Label_Selected_WebPage.Location = new System.Drawing.Point(16, 48);
			this.Label_Selected_WebPage.Name = "Label_Selected_WebPage";
			this.Label_Selected_WebPage.Size = new System.Drawing.Size(456, 16);
			this.Label_Selected_WebPage.TabIndex = 1;
			// 
			// Button_OpenFolderDialog
			// 
			this.Button_OpenFolderDialog.BackColor = System.Drawing.Color.LightGray;
			this.Button_OpenFolderDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button_OpenFolderDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Button_OpenFolderDialog.ForeColor = System.Drawing.Color.Red;
			this.Button_OpenFolderDialog.Location = new System.Drawing.Point(16, 72);
			this.Button_OpenFolderDialog.Name = "Button_OpenFolderDialog";
			this.Button_OpenFolderDialog.Size = new System.Drawing.Size(112, 23);
			this.Button_OpenFolderDialog.TabIndex = 1;
			this.Button_OpenFolderDialog.Text = "Select Folder";
			this.Button_OpenFolderDialog.Click += new System.EventHandler(this.Button_OpenFolderDialog_Click);
			// 
			// Label_Selected_Folder
			// 
			this.Label_Selected_Folder.BackColor = System.Drawing.Color.Transparent;
			this.Label_Selected_Folder.Location = new System.Drawing.Point(16, 104);
			this.Label_Selected_Folder.Name = "Label_Selected_Folder";
			this.Label_Selected_Folder.Size = new System.Drawing.Size(448, 16);
			this.Label_Selected_Folder.TabIndex = 3;
			// 
			// Button_Process_Files
			// 
			this.Button_Process_Files.BackColor = System.Drawing.Color.LightGray;
			this.Button_Process_Files.Enabled = false;
			this.Button_Process_Files.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button_Process_Files.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Button_Process_Files.ForeColor = System.Drawing.Color.Red;
			this.Button_Process_Files.Location = new System.Drawing.Point(16, 128);
			this.Button_Process_Files.Name = "Button_Process_Files";
			this.Button_Process_Files.Size = new System.Drawing.Size(112, 23);
			this.Button_Process_Files.TabIndex = 2;
			this.Button_Process_Files.Text = "Process";
			this.Button_Process_Files.Click += new System.EventHandler(this.Button_Process_Files_Click);
			// 
			// StatusBar_Main
			// 
			this.StatusBar_Main.Location = new System.Drawing.Point(0, 408);
			this.StatusBar_Main.Name = "StatusBar_Main";
			this.StatusBar_Main.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StatusBar_Main.Size = new System.Drawing.Size(488, 22);
			this.StatusBar_Main.TabIndex = 6;
			// 
			// Button_Rename_Files
			// 
			this.Button_Rename_Files.BackColor = System.Drawing.Color.LightGray;
			this.Button_Rename_Files.Enabled = false;
			this.Button_Rename_Files.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button_Rename_Files.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Button_Rename_Files.ForeColor = System.Drawing.Color.Red;
			this.Button_Rename_Files.Location = new System.Drawing.Point(152, 128);
			this.Button_Rename_Files.Name = "Button_Rename_Files";
			this.Button_Rename_Files.Size = new System.Drawing.Size(120, 23);
			this.Button_Rename_Files.TabIndex = 3;
			this.Button_Rename_Files.Text = "Rename Files";
			this.Button_Rename_Files.Click += new System.EventHandler(this.Button_Rename_Files_Click);
			// 
			// CheckBox_Create_Folders
			// 
			this.CheckBox_Create_Folders.BackColor = System.Drawing.Color.Transparent;
			this.CheckBox_Create_Folders.Location = new System.Drawing.Point(16, 376);
			this.CheckBox_Create_Folders.Name = "CheckBox_Create_Folders";
			this.CheckBox_Create_Folders.Size = new System.Drawing.Size(280, 16);
			this.CheckBox_Create_Folders.TabIndex = 8;
			this.CheckBox_Create_Folders.Text = "Create Individual Folders and Move Files Instead";
			// 
			// DataGrid_Processed_Files
			// 
			this.DataGrid_Processed_Files.BackgroundColor = System.Drawing.SystemColors.Window;
			this.DataGrid_Processed_Files.CaptionText = "Processed Files";
			this.DataGrid_Processed_Files.DataMember = "Processed_Files";
			this.DataGrid_Processed_Files.DataSource = this.DataSet_Processed_Files;
			this.DataGrid_Processed_Files.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGrid_Processed_Files.Location = new System.Drawing.Point(8, 16);
			this.DataGrid_Processed_Files.Name = "DataGrid_Processed_Files";
			this.DataGrid_Processed_Files.ReadOnly = true;
			this.DataGrid_Processed_Files.Size = new System.Drawing.Size(440, 176);
			this.DataGrid_Processed_Files.TabIndex = 9;
			this.DataGrid_Processed_Files.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																												 this.Style_Processed_Files});
			this.DataGrid_Processed_Files.Visible = false;
			// 
			// DataSet_Processed_Files
			// 
			this.DataSet_Processed_Files.DataSetName = "DataSet_Processed_Files";
			this.DataSet_Processed_Files.Locale = new System.Globalization.CultureInfo("en-ZA");
			this.DataSet_Processed_Files.Tables.AddRange(new System.Data.DataTable[] {
																						 this.DataTable_Processed_Files});
			// 
			// DataTable_Processed_Files
			// 
			this.DataTable_Processed_Files.Columns.AddRange(new System.Data.DataColumn[] {
																							 this.DataColumn_Filename,
																							 this.DataColumn_Description,
																							 this.DataColumn_Extension,
																							 this.dataColumn1,
																							 this.dataColumn2,
																							 this.dataColumn3});
			this.DataTable_Processed_Files.Constraints.AddRange(new System.Data.Constraint[] {
																								 new System.Data.UniqueConstraint("Constraint1", new string[] {
																																								  "ID"}, true)});
			this.DataTable_Processed_Files.PrimaryKey = new System.Data.DataColumn[] {
																						 this.dataColumn1};
			this.DataTable_Processed_Files.TableName = "Processed_Files";
			// 
			// DataColumn_Filename
			// 
			this.DataColumn_Filename.AllowDBNull = false;
			this.DataColumn_Filename.ColumnName = "Filename";
			// 
			// DataColumn_Description
			// 
			this.DataColumn_Description.AllowDBNull = false;
			this.DataColumn_Description.ColumnName = "Description";
			// 
			// DataColumn_Extension
			// 
			this.DataColumn_Extension.AllowDBNull = false;
			this.DataColumn_Extension.ColumnName = "Extension";
			// 
			// dataColumn1
			// 
			this.dataColumn1.AllowDBNull = false;
			this.dataColumn1.ColumnName = "ID";
			this.dataColumn1.DataType = typeof(int);
			// 
			// dataColumn2
			// 
			this.dataColumn2.ColumnName = "Result";
			// 
			// dataColumn3
			// 
			this.dataColumn3.ColumnName = "Reason";
			// 
			// Style_Processed_Files
			// 
			this.Style_Processed_Files.DataGrid = this.DataGrid_Processed_Files;
			this.Style_Processed_Files.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																													this.Filename_P,
																													this.Description_P,
																													this.Extension_P,
																													this.ID_P});
			this.Style_Processed_Files.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.Style_Processed_Files.MappingName = "Processed_Files";
			this.Style_Processed_Files.ReadOnly = true;
			this.Style_Processed_Files.RowHeadersVisible = false;
			// 
			// Filename_P
			// 
			this.Filename_P.Format = "";
			this.Filename_P.FormatInfo = null;
			this.Filename_P.HeaderText = "Filename";
			this.Filename_P.MappingName = "Filename";
			this.Filename_P.Width = 143;
			// 
			// Description_P
			// 
			this.Description_P.Format = "";
			this.Description_P.FormatInfo = null;
			this.Description_P.HeaderText = "Description";
			this.Description_P.MappingName = "Description";
			this.Description_P.Width = 143;
			// 
			// Extension_P
			// 
			this.Extension_P.Format = "";
			this.Extension_P.FormatInfo = null;
			this.Extension_P.HeaderText = "Extension";
			this.Extension_P.MappingName = "Extension";
			this.Extension_P.Width = 75;
			// 
			// ID_P
			// 
			this.ID_P.Format = "";
			this.ID_P.FormatInfo = null;
			this.ID_P.HeaderText = "ID";
			this.ID_P.MappingName = "ID";
			this.ID_P.Width = 75;
			// 
			// GroupBox_Processed_Files
			// 
			this.GroupBox_Processed_Files.BackColor = System.Drawing.Color.White;
			this.GroupBox_Processed_Files.Controls.Add(this.DataGrid_Renamed_Files);
			this.GroupBox_Processed_Files.Controls.Add(this.DataGrid_Processed_Files);
			this.GroupBox_Processed_Files.Location = new System.Drawing.Point(16, 168);
			this.GroupBox_Processed_Files.Name = "GroupBox_Processed_Files";
			this.GroupBox_Processed_Files.Size = new System.Drawing.Size(456, 200);
			this.GroupBox_Processed_Files.TabIndex = 10;
			this.GroupBox_Processed_Files.TabStop = false;
			this.GroupBox_Processed_Files.Text = "Results";
			// 
			// DataGrid_Renamed_Files
			// 
			this.DataGrid_Renamed_Files.BackgroundColor = System.Drawing.SystemColors.Window;
			this.DataGrid_Renamed_Files.CaptionText = "Renamed Files";
			this.DataGrid_Renamed_Files.ContextMenu = this.ContextMenu_DataGrid_Renamed_Files;
			this.DataGrid_Renamed_Files.DataMember = "Processed_Files";
			this.DataGrid_Renamed_Files.DataSource = this.DataSet_Processed_Files;
			this.DataGrid_Renamed_Files.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGrid_Renamed_Files.Location = new System.Drawing.Point(8, 16);
			this.DataGrid_Renamed_Files.Name = "DataGrid_Renamed_Files";
			this.DataGrid_Renamed_Files.ReadOnly = true;
			this.DataGrid_Renamed_Files.Size = new System.Drawing.Size(440, 176);
			this.DataGrid_Renamed_Files.TabIndex = 11;
			this.DataGrid_Renamed_Files.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																											   this.Style_Renamed_Files});
			this.DataGrid_Renamed_Files.Visible = false;
			this.DataGrid_Renamed_Files.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DataGrid_Renamed_Files_MouseUp);
			// 
			// Style_Renamed_Files
			// 
			this.Style_Renamed_Files.DataGrid = this.DataGrid_Renamed_Files;
			this.Style_Renamed_Files.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.Result,
																												  this.Filename,
																												  this.Description,
																												  this.Reason,
																												  this.ID});
			this.Style_Renamed_Files.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.Style_Renamed_Files.MappingName = "Processed_Files";
			this.Style_Renamed_Files.ReadOnly = true;
			this.Style_Renamed_Files.RowHeadersVisible = false;
			// 
			// Result
			// 
			this.Result.Format = "";
			this.Result.FormatInfo = null;
			this.Result.HeaderText = "Result";
			this.Result.MappingName = "Result";
			this.Result.Width = 60;
			// 
			// Filename
			// 
			this.Filename.Format = "";
			this.Filename.FormatInfo = null;
			this.Filename.HeaderText = "Filename";
			this.Filename.MappingName = "Filename";
			this.Filename.Width = 110;
			// 
			// Description
			// 
			this.Description.Format = "";
			this.Description.FormatInfo = null;
			this.Description.HeaderText = "Description";
			this.Description.MappingName = "Description";
			this.Description.Width = 110;
			// 
			// Reason
			// 
			this.Reason.Format = "";
			this.Reason.FormatInfo = null;
			this.Reason.HeaderText = "Reason";
			this.Reason.MappingName = "Reason";
			this.Reason.NullText = "";
			this.Reason.Width = 120;
			// 
			// ID
			// 
			this.ID.Format = "";
			this.ID.FormatInfo = null;
			this.ID.HeaderText = "ID";
			this.ID.MappingName = "ID";
			this.ID.Width = 36;
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.Description = "Select the folder to which the selected HTML document refers to.";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(296, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 11;
			this.label1.Text = "About |";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(248, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 12;
			this.label2.Text = "Help |";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(240, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(8, 23);
			this.label3.TabIndex = 13;
			this.label3.Text = "|";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Red;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(24, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(352, 152);
			this.panel1.TabIndex = 14;
			this.panel1.Visible = false;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Red;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(104, 104);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(112, 16);
			this.label12.TabIndex = 8;
			this.label12.Text = "Craig Lotter";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Red;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(104, 88);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(112, 16);
			this.label11.TabIndex = 7;
			this.label11.Text = "01/05/2004";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Red;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(104, 72);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(112, 16);
			this.label10.TabIndex = 6;
			this.label10.Text = "1.0.1";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Red;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(104, 56);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(224, 16);
			this.label9.TabIndex = 5;
			this.label9.Text = "HREF Reference File Renamer 1.0 Beta";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Red;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(32, 104);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 16);
			this.label8.TabIndex = 4;
			this.label8.Text = "Developer:";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Red;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(32, 88);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 16);
			this.label7.TabIndex = 3;
			this.label7.Text = "Created:";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Red;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(32, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 16);
			this.label6.TabIndex = 2;
			this.label6.Text = "Build:";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Red;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(32, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 16);
			this.label5.TabIndex = 1;
			this.label5.Text = "Version:";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Red;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(32, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(288, 24);
			this.label4.TabIndex = 0;
			this.label4.Text = "About";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Red;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label15);
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.label20);
			this.panel2.Controls.Add(this.label21);
			this.panel2.Location = new System.Drawing.Point(24, 32);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(432, 256);
			this.panel2.TabIndex = 17;
			this.panel2.Visible = false;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Red;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.White;
			this.label15.Location = new System.Drawing.Point(8, 200);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(424, 48);
			this.label15.TabIndex = 4;
			this.label15.Text = "A further option is available whereby instead of renaming the files, folders are " +
				"created based on the descriptive label of the links and the linked files are mov" +
				"ed to these corresponding folders.";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Red;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(8, 160);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(424, 32);
			this.label14.TabIndex = 3;
			this.label14.Text = "The \"Process\" button parses the HTML document while the \"Rename Files\" button han" +
				"dles the actual file rename process.";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Red;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(8, 120);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(424, 32);
			this.label13.TabIndex = 2;
			this.label13.Text = "To begin the process, select a valid HTML file and then the corresponding folder " +
				"where the files referred to in the HTML document are stored.";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Red;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.ForeColor = System.Drawing.Color.White;
			this.label20.Location = new System.Drawing.Point(8, 56);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(424, 56);
			this.label20.TabIndex = 1;
			this.label20.Text = @"HREF Reference File Renamer is a simple tool used to name linked files according to the textual description found in the anchor tag of a HTML document. For instance, should a local webpage contain the following line: ""<a href=""Go.doc"">How to Play Go</a>"", the program will rename ""Go.doc"" to ""How_to_Play_Go.doc"".";
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Red;
			this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label21.ForeColor = System.Drawing.Color.White;
			this.label21.Location = new System.Drawing.Point(64, 16);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(288, 24);
			this.label21.TabIndex = 0;
			this.label21.Text = "Help";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.Location = new System.Drawing.Point(344, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(40, 23);
			this.label16.TabIndex = 18;
			this.label16.Text = "Exit |";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label16.Click += new System.EventHandler(this.label16_Click);
			// 
			// Main_Form
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(488, 430);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.GroupBox_Processed_Files);
			this.Controls.Add(this.CheckBox_Create_Folders);
			this.Controls.Add(this.Button_Rename_Files);
			this.Controls.Add(this.StatusBar_Main);
			this.Controls.Add(this.Button_Process_Files);
			this.Controls.Add(this.Label_Selected_Folder);
			this.Controls.Add(this.Button_OpenFolderDialog);
			this.Controls.Add(this.Label_Selected_WebPage);
			this.Controls.Add(this.Button_OpenWebPageDialog);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(496, 464);
			this.MinimumSize = new System.Drawing.Size(496, 464);
			this.Name = "Main_Form";
			this.Text = "HREF Reference File Renamer 1.0";
			this.Load += new System.EventHandler(this.Main_Form_Load);
			((System.ComponentModel.ISupportInitialize)(this.DataGrid_Processed_Files)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataSet_Processed_Files)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataTable_Processed_Files)).EndInit();
			this.GroupBox_Processed_Files.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGrid_Renamed_Files)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Main_Form());
		}

		private void Button_OpenWebPageDialog_Click(object sender, System.EventArgs e)
		{
			Dialog_openWebPageDialog.ShowDialog();
			string selectedFile = Dialog_openWebPageDialog.FileName;
			if (File.Exists(selectedFile))
			{
				Label_Selected_WebPage.Text = Dialog_openWebPageDialog.FileName;
			}
			if ((Label_Selected_WebPage.Text.Length > 0) & (Label_Selected_Folder.Text.Length > 0))
				Button_Process_Files.Enabled = true;

			if ((DataGrid_Processed_Files.Visible == true) || (DataGrid_Renamed_Files.Visible == true))
			{
				DataGrid_Renamed_Files.Visible = false;
				DataGrid_Processed_Files.Visible = false;
			}
		}

		private void Button_OpenFolderDialog_Click(object sender, System.EventArgs e)
		{
			folderBrowserDialog1.ShowDialog();
			//Dialog_openFolderDialog.ShowDialog();
			//string selectedFile = Dialog_openFolderDialog.FileName;
			//if (File.Exists(selectedFile) || Directory.Exists(selectedFile))
			//{
				//DirectoryInfo directory_info = Directory.GetParent(Dialog_openFolderDialog.FileName);
				//Label_Selected_Folder.Text = directory_info.FullName;
			//}		
			
			string selectedFolder = folderBrowserDialog1.SelectedPath;
			Label_Selected_Folder.Text = selectedFolder;
			if ((Label_Selected_WebPage.Text.Length > 0) & (Label_Selected_Folder.Text.Length > 0))
				Button_Process_Files.Enabled = true;

			if ((DataGrid_Processed_Files.Visible == true) || (DataGrid_Renamed_Files.Visible == true))
			{
				DataGrid_Renamed_Files.Visible = false;
				DataGrid_Processed_Files.Visible = false;
			}
		}

		private void Button_Process_Files_Click(object sender, System.EventArgs e)
		{
		
			DataTable DataTable1 = DataSet_Processed_Files.Tables["Processed_Files"];
			DataTable1.Clear();
			DataGrid_Processed_Files.Visible = false;
			StatusBar_Main.Text = "";
			int symbol = 0;

			StreamReader file_reader = new StreamReader(Label_Selected_WebPage.Text, true);
		
			string read = "";
			string read2 = "";
			int HREF_startindex = 0;
			int HREF_endindex = 0;
			bool search_startindex = true;
			bool search_endindex = false;
			int found_counter = 0;
			string filename = "";
			string extension = "";
			string description = "";
			
			while (read2 != null)
			{
				read2 = file_reader.ReadLine();
				if (read2 != null)
					read2 = read2.Trim();
				read = read + " " + read2;
				
				if (search_startindex == true)
				{
					HREF_startindex = read.ToLower().IndexOf ("href",0);
					if (HREF_startindex == -1)
					{
						search_startindex = true;
						search_endindex = false;
					}
					else
					{
						search_startindex = false;
						search_endindex = true;
					}
				}

				if (search_endindex == true)
				{
					HREF_endindex = read.ToLower().IndexOf ("</a>",HREF_startindex);
					if (HREF_endindex == -1)
					{
						search_startindex = false;
						search_endindex = true;
					}
					else
					{
						search_startindex = true;
						search_endindex = false;

						string found = read.Substring(HREF_startindex,(HREF_endindex + 3 - HREF_startindex + 1));
						read = read.Remove(0,(HREF_endindex + 3));
						
						try
						{
							description = Parse_Description(found);
							filename = Parse_Filename(found);
							extension = Parse_Extension(filename);
							if ((description != "" ) & (description != null))
							{
								DataRow inputdata = DataTable1.NewRow();
								inputdata["Description"] = description;
								inputdata["Extension"] = extension;
								inputdata["Filename"] = filename;
								inputdata["ID"] = found_counter + 1;
								DataTable1.Rows.Add(inputdata);
								found_counter += 1;
							}		
						}
						catch (System.Data.ConstraintException constraint_exception)
						{
							MessageBox.Show(constraint_exception.Message);								
						}
							
										
					}
				}
				
				if (symbol == 0) StatusBar_Main.Text = "Processing.";
				if (symbol == 1) StatusBar_Main.Text = "Processing..";
				if (symbol == 2) StatusBar_Main.Text = "Processing...";
				if (symbol == 3) StatusBar_Main.Text = "Processing....";
				if (symbol == 4) StatusBar_Main.Text = "Processing.....";
				symbol = symbol + 1;
				if (symbol == 5) symbol = 0;
			}
			file_reader.Close();

			DataGrid_Processed_Files.Visible = true;

			StatusBar_Main.Text = "Processed. " + found_counter.ToString() + " HREF tags located.";
			Button_Rename_Files.Enabled = true;						
		}


		private string Parse_Description(string input)
		{
			int startindex = 0;
			int endindex = 0;
			
			input = input.Trim();
			string output = input;
			
			startindex = input.ToLower().IndexOf (">",0);
			if (startindex != -1)
			{
				endindex = input.ToLower().IndexOf("</a>",startindex);
				if (endindex != -1)
				{
					output = input.Substring((startindex + 1),(endindex - (startindex + 1)));
				}
			}
			if (output != "")
			{
				output = Replace_Special_Characters(output);
				output = output.Replace(" ","_");
				output = output.Trim();
			}
			return output;
		}

		private string Parse_Filename(string input)
		{
			int startindex = 0;
			int endindex = 0;
			
			input = input.Trim();
			string output = input;
			
			startindex = input.ToLower().IndexOf ("href=\"",0);
			if (startindex != -1)
			{
				endindex = input.ToLower().IndexOf("\"",(startindex + 6));
				if (endindex != -1)
				{
					output = input.Substring((startindex + 6),(endindex - (startindex + 6)));
				}
			}

			startindex = 0;
			startindex = LastIndexOf(output,"/");
	
			if (startindex != -1)
			{
					output = output.Substring((startindex + 1),(output.Length - (startindex + 1)));
			}
			if (output != "")
			{
				output = Replace_Special_Characters(output);
				output = output.Trim();
			}
			return output;
		}

		private string Parse_Extension(string input)
		{
			string output = input;
			int startindex = 0;
			startindex = LastIndexOf(output,".");
	
			if (startindex != -1)
			{
				output = output.Substring((startindex + 1),(output.Length - (startindex + 1)));
			}

			return output;
		}


		private string Replace_Special_Characters(string input)
		{
			input = input.Replace('\u005C','\u00A0');
			input = input.Replace('\u002F','\u00A0');
			input = input.Replace('\u003A','\u00A0');
			input = input.Replace('\u002A','\u00A0');
			input = input.Replace('\u003F','\u00A0');
			input = input.Replace('\u0022','\u00A0');
			input = input.Replace('\u003C','\u00A0');
			input = input.Replace('\u003E','\u00A0');
			input = input.Replace('\u007C','\u00A0');
			input = input.Replace("%20"," ");
			return input;
		}

		private int LastIndexOf(string input, string searchchar)
		{
			int startindex = -1;
			int result = -1;
	
			do
			{
				startindex = input.IndexOf(searchchar,startindex + 1);
				if (startindex != -1)
				{
					result = startindex;
				}
			}
			while (startindex > -1);
			return result;
		}

		private void Button_Rename_Files_Click(object sender, System.EventArgs e)
		{
			DataTable DataTable1 = DataSet_Processed_Files.Tables["Processed_Files"];			
			StatusBar_Main.Text = "";
			int symbol = 0;
			int found_counter = 0;

			for (int i = 0; i<DataTable1.Rows.Count; i++)
			{
				DataRow currentrow = DataTable1.Rows[i];
				string description = currentrow["Description"].ToString();
				string extension = currentrow["Extension"].ToString();
				string filename = currentrow["Filename"].ToString();
				string reason = "";
				bool gotresult = false;
				FileInfo file = new FileInfo(Label_Selected_Folder.Text + "\\" + filename);
				if (description.EndsWith("." + extension) == true)
				{
					description = description.Remove(description.Length - 4,4); 
				}
				
				if ((description == "") || (description == null))
				{ 
					description = "ERROR - No Description";
				}
					
				if ((file.Exists == true) & (File.Exists(Label_Selected_Folder.Text + "\\" + description + "." + extension) == false) & (File.Exists(Label_Selected_Folder.Text + "\\" + description + "\\" + file.Name) == false))
				{
					if (CheckBox_Create_Folders.Checked == true)
					{
						if (Directory.Exists(Label_Selected_Folder.Text + "\\" + description) == false)
						{
							Directory.CreateDirectory(Label_Selected_Folder.Text + "\\" + description);
						}
						file.MoveTo(Label_Selected_Folder.Text + "\\" + description + "\\" + file.Name);
						currentrow.BeginEdit();
						currentrow["Result"] = "Success";
						currentrow.AcceptChanges();
						currentrow.EndEdit();
						gotresult = true;
						found_counter = found_counter + 1;
					}
					else
					{
						file.MoveTo(Label_Selected_Folder.Text + "\\" + description + "." + extension);
						currentrow.BeginEdit();
						currentrow["Result"] = "Success";
						currentrow.AcceptChanges();
						currentrow.EndEdit();
						gotresult = true;
						found_counter = found_counter + 1;
					}
					
				}
				if (file.Exists != true)
				{
					reason = reason + "File to be renamed doesn't exist. ";
				}
				if (File.Exists(Label_Selected_Folder.Text + "\\" + description + "." + extension) != false) 
				{
					reason = reason + "New filename already exists. ";
				}
				if (File.Exists(Label_Selected_Folder.Text + "\\" + description + "\\" + description + "." + extension) != false)
				{
					reason = reason + "New filepath already exists. ";
				}
				if (gotresult == false)
				{
					currentrow.BeginEdit();
					currentrow["Result"] = "Failed";
					currentrow["Reason"] = reason;
					currentrow.AcceptChanges();
					currentrow.EndEdit();
				}

                if (symbol == 0) StatusBar_Main.Text = "Renaming.";
				if (symbol == 1) StatusBar_Main.Text = "Renaming..";
				if (symbol == 2) StatusBar_Main.Text = "Renaming...";
				if (symbol == 3) StatusBar_Main.Text = "Renaming....";
				if (symbol == 4) StatusBar_Main.Text = "Renaming.....";
				symbol = symbol + 1;
				if (symbol == 5) symbol = 0;
			}


			DataGrid_Processed_Files.Visible = false;
			DataGrid_Renamed_Files.Visible = true;

			StatusBar_Main.Text = "Renamed. " + found_counter.ToString() + " files renamed.";

			Button_Process_Files.Enabled = false;
			Button_Rename_Files.Enabled = false;			
		}

		private void DataGrid_Renamed_Files_MouseUp(object sender, System.Windows.Forms.MouseEventArgs me)
		{
//			Point pt = new Point(me.X, me.Y);
//				System.Windows.Forms.DataGrid.HitInfo hit = DataGrid_Renamed_Files.HitTest(pt);


			
		}

		private void Main_Form_Load(object sender, System.EventArgs e)
		{
		Label_Selected_WebPage.Select();
		}

		private void label1_Click(object sender, System.EventArgs e)
		{
			if (panel1.Visible == false) 
			{
				panel1.Visible = true;
				panel2.Visible = false;
			}
			else
			{panel1.Visible = false;}


		}

		private void label2_Click(object sender, System.EventArgs e)
		{
			if (panel2.Visible == false) 
			{
				panel2.Visible = true;
					panel1.Visible = false;
			}
			else
			{panel2.Visible = false;}

		}

		private void label16_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

//		Private Sub DataGrid1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGrid1.MouseUp
//		Dim pt = New Point(e.X, e.Y)
//		Dim hit As DataGrid.HitTestInfo = DataGrid1.HitTest(pt)
//
//		If hit.Type = DataGrid.HitTestType.Cell Then
//						  DataGrid1.CurrentCell = New DataGridCell(hit.Row, hit.Column)
//													  DataGrid1.Select(hit.Row)
//		End If
//
//			End Sub

	}
}
