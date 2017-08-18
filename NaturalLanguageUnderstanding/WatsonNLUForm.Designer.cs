/*
 * Copyright 2017 IBM Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
namespace WatsonDeveloperCloudExample
{
    partial class NLUForm
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
            System.Windows.Forms.GroupBox credentialsGroupBox;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label corpusLabel;
            System.Windows.Forms.Label analysisLabel;
            System.Windows.Forms.PictureBox watsonLogoPictureBox;
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.corpusTextBox = new System.Windows.Forms.TextBox();
            this.jsonTreeView = new System.Windows.Forms.TreeView();
            this.analyzeButton = new System.Windows.Forms.Button();
            credentialsGroupBox = new System.Windows.Forms.GroupBox();
            passwordLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            corpusLabel = new System.Windows.Forms.Label();
            analysisLabel = new System.Windows.Forms.Label();
            watsonLogoPictureBox = new System.Windows.Forms.PictureBox();
            credentialsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(watsonLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // credentialsGroupBox
            // 
            credentialsGroupBox.CausesValidation = false;
            credentialsGroupBox.Controls.Add(passwordLabel);
            credentialsGroupBox.Controls.Add(this.passwordTextBox);
            credentialsGroupBox.Controls.Add(usernameLabel);
            credentialsGroupBox.Controls.Add(this.usernameTextBox);
            credentialsGroupBox.Location = new System.Drawing.Point(12, 12);
            credentialsGroupBox.Name = "credentialsGroupBox";
            credentialsGroupBox.Size = new System.Drawing.Size(321, 76);
            credentialsGroupBox.TabIndex = 0;
            credentialsGroupBox.TabStop = false;
            credentialsGroupBox.Text = "NLU Credentials";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.CausesValidation = false;
            passwordLabel.Location = new System.Drawing.Point(6, 48);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(53, 13);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(67, 45);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(160, 20);
            this.passwordTextBox.TabIndex = 2;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.CausesValidation = false;
            usernameLabel.Location = new System.Drawing.Point(6, 22);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(55, 13);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(67, 19);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(248, 20);
            this.usernameTextBox.TabIndex = 0;
            // 
            // corpusLabel
            // 
            corpusLabel.AutoSize = true;
            corpusLabel.Location = new System.Drawing.Point(12, 91);
            corpusLabel.Name = "corpusLabel";
            corpusLabel.Size = new System.Drawing.Size(40, 13);
            corpusLabel.TabIndex = 1;
            corpusLabel.Text = "Corpus";
            // 
            // analysisLabel
            // 
            analysisLabel.AutoSize = true;
            analysisLabel.Location = new System.Drawing.Point(439, 91);
            analysisLabel.Name = "analysisLabel";
            analysisLabel.Size = new System.Drawing.Size(45, 13);
            analysisLabel.TabIndex = 4;
            analysisLabel.Text = "Analysis";
            // 
            // corpusTextBox
            // 
            this.corpusTextBox.Location = new System.Drawing.Point(12, 107);
            this.corpusTextBox.Multiline = true;
            this.corpusTextBox.Name = "corpusTextBox";
            this.corpusTextBox.Size = new System.Drawing.Size(424, 524);
            this.corpusTextBox.TabIndex = 2;
            // 
            // jsonTreeView
            // 
            this.jsonTreeView.Location = new System.Drawing.Point(442, 107);
            this.jsonTreeView.Name = "jsonTreeView";
            this.jsonTreeView.Size = new System.Drawing.Size(348, 524);
            this.jsonTreeView.TabIndex = 3;
            // 
            // analyzeButton
            // 
            this.analyzeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.analyzeButton.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyzeButton.Location = new System.Drawing.Point(442, 12);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(348, 76);
            this.analyzeButton.TabIndex = 5;
            this.analyzeButton.Text = "Analyze";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // watsonLogoPictureBox
            // 
            watsonLogoPictureBox.Image = global::WatsonDeveloperCloudExample.Properties.Resources.Watson;
            watsonLogoPictureBox.Location = new System.Drawing.Point(351, 12);
            watsonLogoPictureBox.Name = "watsonLogoPictureBox";
            watsonLogoPictureBox.Size = new System.Drawing.Size(85, 89);
            watsonLogoPictureBox.TabIndex = 6;
            watsonLogoPictureBox.TabStop = false;
            // 
            // NLUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 643);
            this.Controls.Add(watsonLogoPictureBox);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(analysisLabel);
            this.Controls.Add(this.jsonTreeView);
            this.Controls.Add(this.corpusTextBox);
            this.Controls.Add(corpusLabel);
            this.Controls.Add(credentialsGroupBox);
            this.Name = "NLUForm";
            this.Text = "Watson Natural Language Understanding C# Demo";
            credentialsGroupBox.ResumeLayout(false);
            credentialsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(watsonLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox corpusTextBox;
        private System.Windows.Forms.TreeView jsonTreeView;
        private System.Windows.Forms.Button analyzeButton;
    }
}

