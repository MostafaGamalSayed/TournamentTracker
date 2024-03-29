﻿namespace TournamentTrackUI
{
    partial class CreatePrizeForm
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.PlaceNumberLabel = new System.Windows.Forms.Label();
            this.PlaceNumberValue = new System.Windows.Forms.TextBox();
            this.PlaceNameLabel = new System.Windows.Forms.Label();
            this.PlaceNameValue = new System.Windows.Forms.TextBox();
            this.PrizeAmountLabel = new System.Windows.Forms.Label();
            this.PrizeAmountValue = new System.Windows.Forms.TextBox();
            this.PrizePercentageLabel = new System.Windows.Forms.Label();
            this.PrizePercentageValue = new System.Windows.Forms.TextBox();
            this.OrLabel = new System.Windows.Forms.Label();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.HeaderLabel.Location = new System.Drawing.Point(27, 23);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(178, 32);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Create New Prize";
            // 
            // PlaceNumberLabel
            // 
            this.PlaceNumberLabel.AutoSize = true;
            this.PlaceNumberLabel.Location = new System.Drawing.Point(55, 190);
            this.PlaceNumberLabel.Name = "PlaceNumberLabel";
            this.PlaceNumberLabel.Size = new System.Drawing.Size(103, 26);
            this.PlaceNumberLabel.TabIndex = 1;
            this.PlaceNumberLabel.Text = "Place Number";
            // 
            // PlaceNumberValue
            // 
            this.PlaceNumberValue.Location = new System.Drawing.Point(172, 190);
            this.PlaceNumberValue.Name = "PlaceNumberValue";
            this.PlaceNumberValue.Size = new System.Drawing.Size(60, 31);
            this.PlaceNumberValue.TabIndex = 2;
            // 
            // PlaceNameLabel
            // 
            this.PlaceNameLabel.AutoSize = true;
            this.PlaceNameLabel.Location = new System.Drawing.Point(55, 120);
            this.PlaceNameLabel.Name = "PlaceNameLabel";
            this.PlaceNameLabel.Size = new System.Drawing.Size(88, 26);
            this.PlaceNameLabel.TabIndex = 3;
            this.PlaceNameLabel.Text = "Place Name";
            // 
            // PlaceNameValue
            // 
            this.PlaceNameValue.Location = new System.Drawing.Point(172, 120);
            this.PlaceNameValue.Name = "PlaceNameValue";
            this.PlaceNameValue.Size = new System.Drawing.Size(363, 31);
            this.PlaceNameValue.TabIndex = 4;
            // 
            // PrizeAmountLabel
            // 
            this.PrizeAmountLabel.AutoSize = true;
            this.PrizeAmountLabel.Location = new System.Drawing.Point(55, 264);
            this.PrizeAmountLabel.Name = "PrizeAmountLabel";
            this.PrizeAmountLabel.Size = new System.Drawing.Size(101, 26);
            this.PrizeAmountLabel.TabIndex = 5;
            this.PrizeAmountLabel.Text = "Prize Amount";
            // 
            // PrizeAmountValue
            // 
            this.PrizeAmountValue.Location = new System.Drawing.Point(172, 261);
            this.PrizeAmountValue.Name = "PrizeAmountValue";
            this.PrizeAmountValue.Size = new System.Drawing.Size(60, 31);
            this.PrizeAmountValue.TabIndex = 6;
            // 
            // PrizePercentageLabel
            // 
            this.PrizePercentageLabel.AutoSize = true;
            this.PrizePercentageLabel.Location = new System.Drawing.Point(332, 264);
            this.PrizePercentageLabel.Name = "PrizePercentageLabel";
            this.PrizePercentageLabel.Size = new System.Drawing.Size(117, 26);
            this.PrizePercentageLabel.TabIndex = 7;
            this.PrizePercentageLabel.Text = "Prize Percentage";
            // 
            // PrizePercentageValue
            // 
            this.PrizePercentageValue.Location = new System.Drawing.Point(475, 261);
            this.PrizePercentageValue.Name = "PrizePercentageValue";
            this.PrizePercentageValue.Size = new System.Drawing.Size(60, 31);
            this.PrizePercentageValue.TabIndex = 8;
            // 
            // OrLabel
            // 
            this.OrLabel.AutoSize = true;
            this.OrLabel.Font = new System.Drawing.Font("Traditional Arabic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrLabel.Location = new System.Drawing.Point(257, 266);
            this.OrLabel.Name = "OrLabel";
            this.OrLabel.Size = new System.Drawing.Size(52, 23);
            this.OrLabel.TabIndex = 9;
            this.OrLabel.Text = "- OR - ";
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.ForeColor = System.Drawing.Color.White;
            this.CreatePrizeButton.Location = new System.Drawing.Point(60, 381);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(139, 50);
            this.CreatePrizeButton.TabIndex = 10;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = false;
            this.CreatePrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 560);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.OrLabel);
            this.Controls.Add(this.PrizePercentageValue);
            this.Controls.Add(this.PrizePercentageLabel);
            this.Controls.Add(this.PrizeAmountValue);
            this.Controls.Add(this.PrizeAmountLabel);
            this.Controls.Add(this.PlaceNameValue);
            this.Controls.Add(this.PlaceNameLabel);
            this.Controls.Add(this.PlaceNumberValue);
            this.Controls.Add(this.PlaceNumberLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreatePrizeForm";
            this.Text = "Create New Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label PlaceNumberLabel;
        private System.Windows.Forms.TextBox PlaceNumberValue;
        private System.Windows.Forms.Label PlaceNameLabel;
        private System.Windows.Forms.TextBox PlaceNameValue;
        private System.Windows.Forms.Label PrizeAmountLabel;
        private System.Windows.Forms.TextBox PrizeAmountValue;
        private System.Windows.Forms.Label PrizePercentageLabel;
        private System.Windows.Forms.TextBox PrizePercentageValue;
        private System.Windows.Forms.Label OrLabel;
        private System.Windows.Forms.Button CreatePrizeButton;
    }
}

