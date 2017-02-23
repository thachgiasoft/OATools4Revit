﻿namespace OATools.DNotes
{
    partial class frmCreateDNote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbxSheet_number = new System.Windows.Forms.TextBox();
            this.tbxDNoteNumber = new System.Windows.Forms.TextBox();
            this.tbxDNoteText = new System.Windows.Forms.TextBox();
            this.dgvNotesFromFile = new System.Windows.Forms.DataGridView();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbxFilePath = new System.Windows.Forms.TextBox();
            this.btnNewCSV = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotesFromFile)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(900, 958);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(132, 36);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbxSheet_number
            // 
            this.tbxSheet_number.Enabled = false;
            this.tbxSheet_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSheet_number.Location = new System.Drawing.Point(177, 68);
            this.tbxSheet_number.Name = "tbxSheet_number";
            this.tbxSheet_number.Size = new System.Drawing.Size(115, 30);
            this.tbxSheet_number.TabIndex = 1;
            this.tbxSheet_number.TextChanged += new System.EventHandler(this.tbxSheet_number_TextChanged);
            // 
            // tbxDNoteNumber
            // 
            this.tbxDNoteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDNoteNumber.Location = new System.Drawing.Point(177, 16);
            this.tbxDNoteNumber.Name = "tbxDNoteNumber";
            this.tbxDNoteNumber.Size = new System.Drawing.Size(115, 30);
            this.tbxDNoteNumber.TabIndex = 2;
            this.tbxDNoteNumber.TextChanged += new System.EventHandler(this.tbxDNoteNumber_TextChanged);
            // 
            // tbxDNoteText
            // 
            this.tbxDNoteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDNoteText.Location = new System.Drawing.Point(12, 241);
            this.tbxDNoteText.Multiline = true;
            this.tbxDNoteText.Name = "tbxDNoteText";
            this.tbxDNoteText.Size = new System.Drawing.Size(1020, 121);
            this.tbxDNoteText.TabIndex = 3;
            this.tbxDNoteText.TextChanged += new System.EventHandler(this.txbDNoteText_TextChanged);
            // 
            // dgvNotesFromFile
            // 
            this.dgvNotesFromFile.AllowUserToAddRows = false;
            this.dgvNotesFromFile.AllowUserToDeleteRows = false;
            this.dgvNotesFromFile.AllowUserToResizeColumns = false;
            this.dgvNotesFromFile.AllowUserToResizeRows = false;
            this.dgvNotesFromFile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotesFromFile.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNotesFromFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNotesFromFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotesFromFile.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNotesFromFile.Location = new System.Drawing.Point(12, 403);
            this.dgvNotesFromFile.Name = "dgvNotesFromFile";
            this.dgvNotesFromFile.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            this.dgvNotesFromFile.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotesFromFile.RowTemplate.Height = 24;
            this.dgvNotesFromFile.Size = new System.Drawing.Size(1020, 537);
            this.dgvNotesFromFile.TabIndex = 4;
            this.dgvNotesFromFile.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotesFromFile_CellContentClick);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(900, 41);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(132, 27);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // tbxFilePath
            // 
            this.tbxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFilePath.Location = new System.Drawing.Point(12, 41);
            this.tbxFilePath.Name = "tbxFilePath";
            this.tbxFilePath.Size = new System.Drawing.Size(865, 27);
            this.tbxFilePath.TabIndex = 6;
            this.tbxFilePath.TextChanged += new System.EventHandler(this.tbxFilePath_TextChanged);
            // 
            // btnNewCSV
            // 
            this.btnNewCSV.Location = new System.Drawing.Point(900, 74);
            this.btnNewCSV.Name = "btnNewCSV";
            this.btnNewCSV.Size = new System.Drawing.Size(132, 27);
            this.btnNewCSV.TabIndex = 10;
            this.btnNewCSV.Text = "Create New File";
            this.btnNewCSV.UseVisualStyleBackColor = true;
            this.btnNewCSV.Click += new System.EventHandler(this.btnNewCSV_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.FileName = "DNotes";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Loaded DNote File path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Note Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxSheet_number);
            this.groupBox1.Controls.Add(this.tbxDNoteNumber);
            this.groupBox1.Location = new System.Drawing.Point(16, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 109);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sheet Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "DNote Text:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "DNotes from file:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 958);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 36);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(885, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add To DNote File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCreateDNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 1006);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewCSV);
            this.Controls.Add(this.tbxFilePath);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.dgvNotesFromFile);
            this.Controls.Add(this.tbxDNoteText);
            this.Controls.Add(this.btnOK);
            this.Name = "frmCreateDNote";
            this.Text = "frmCreateDNote";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotesFromFile)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbxSheet_number;
        private System.Windows.Forms.TextBox tbxDNoteNumber;
        private System.Windows.Forms.TextBox tbxDNoteText;
        private System.Windows.Forms.DataGridView dgvNotesFromFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbxFilePath;
        private System.Windows.Forms.Button btnNewCSV;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
    }
}