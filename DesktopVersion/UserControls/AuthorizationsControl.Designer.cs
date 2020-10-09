﻿namespace DesktopVersion
{
	partial class AuthorizationsControl
	{
		private System.ComponentModel.IContainer components = null;
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Label labelAuthorizationsMain;
			System.Windows.Forms.Label lableNoAcc;
			this.textBoxUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.textBoxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.buttonAuth = new Bunifu.Framework.UI.BunifuFlatButton();
			labelAuthorizationsMain = new System.Windows.Forms.Label();
			lableNoAcc = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelAuthorizationsMain
			// 
			labelAuthorizationsMain.AutoSize = true;
			labelAuthorizationsMain.Font = new System.Drawing.Font("Century Gothic", 20.75F);
			labelAuthorizationsMain.ForeColor = System.Drawing.Color.Firebrick;
			labelAuthorizationsMain.Location = new System.Drawing.Point(2, 1);
			labelAuthorizationsMain.Name = "labelAuthorizationsMain";
			labelAuthorizationsMain.Size = new System.Drawing.Size(280, 34);
			labelAuthorizationsMain.TabIndex = 4;
			labelAuthorizationsMain.Text = "Войдите в систему";
			// 
			// lableNoAcc
			// 
			lableNoAcc.AutoSize = true;
			lableNoAcc.Font = new System.Drawing.Font("Century Gothic", 13.75F, System.Drawing.FontStyle.Underline);
			lableNoAcc.ForeColor = System.Drawing.Color.Firebrick;
			lableNoAcc.Location = new System.Drawing.Point(4, 249);
			lableNoAcc.Name = "lableNoAcc";
			lableNoAcc.Size = new System.Drawing.Size(206, 22);
			lableNoAcc.TabIndex = 4;
			lableNoAcc.Text = "Отсуствует аккаунт?";
			lableNoAcc.Click += new System.EventHandler(this.lableNoAcc_Click);
			// 
			// textBoxUserName
			// 
			this.textBoxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxUserName.Font = new System.Drawing.Font("Century Gothic", 12.75F);
			this.textBoxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.textBoxUserName.HintForeColor = System.Drawing.Color.Gray;
			this.textBoxUserName.HintText = "Логин";
			this.textBoxUserName.isPassword = false;
			this.textBoxUserName.LineFocusedColor = System.Drawing.Color.Firebrick;
			this.textBoxUserName.LineIdleColor = System.Drawing.Color.Firebrick;
			this.textBoxUserName.LineMouseHoverColor = System.Drawing.Color.Firebrick;
			this.textBoxUserName.LineThickness = 4;
			this.textBoxUserName.Location = new System.Drawing.Point(8, 66);
			this.textBoxUserName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new System.Drawing.Size(500, 50);
			this.textBoxUserName.TabIndex = 1;
			this.textBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 12.75F);
			this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.textBoxPassword.HintForeColor = System.Drawing.Color.Gray;
			this.textBoxPassword.HintText = "Пароль";
			this.textBoxPassword.isPassword = false;
			this.textBoxPassword.LineFocusedColor = System.Drawing.Color.Firebrick;
			this.textBoxPassword.LineIdleColor = System.Drawing.Color.Firebrick;
			this.textBoxPassword.LineMouseHoverColor = System.Drawing.Color.Firebrick;
			this.textBoxPassword.LineThickness = 4;
			this.textBoxPassword.Location = new System.Drawing.Point(8, 148);
			this.textBoxPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(500, 50);
			this.textBoxPassword.TabIndex = 2;
			this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.textBoxPassword.OnValueChanged += new System.EventHandler(this.textBoxPassword_OnValueChanged);
			// 
			// buttonAuth
			// 
			this.buttonAuth.Activecolor = System.Drawing.Color.Brown;
			this.buttonAuth.BackColor = System.Drawing.Color.Firebrick;
			this.buttonAuth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonAuth.BorderRadius = 0;
			this.buttonAuth.ButtonText = "   Авторизоваться";
			this.buttonAuth.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAuth.DisabledColor = System.Drawing.Color.Gray;
			this.buttonAuth.Font = new System.Drawing.Font("Century Gothic", 8.75F);
			this.buttonAuth.Iconcolor = System.Drawing.Color.Transparent;
			this.buttonAuth.Iconimage = global::DesktopVersion.Properties.Resources.loginInIcon;
			this.buttonAuth.Iconimage_right = null;
			this.buttonAuth.Iconimage_right_Selected = null;
			this.buttonAuth.Iconimage_Selected = null;
			this.buttonAuth.IconMarginLeft = 0;
			this.buttonAuth.IconMarginRight = 0;
			this.buttonAuth.IconRightVisible = true;
			this.buttonAuth.IconRightZoom = 0D;
			this.buttonAuth.IconVisible = true;
			this.buttonAuth.IconZoom = 70D;
			this.buttonAuth.IsTab = false;
			this.buttonAuth.Location = new System.Drawing.Point(296, 217);
			this.buttonAuth.Margin = new System.Windows.Forms.Padding(5);
			this.buttonAuth.Name = "buttonAuth";
			this.buttonAuth.Normalcolor = System.Drawing.Color.Firebrick;
			this.buttonAuth.OnHovercolor = System.Drawing.Color.Brown;
			this.buttonAuth.OnHoverTextColor = System.Drawing.Color.White;
			this.buttonAuth.selected = false;
			this.buttonAuth.Size = new System.Drawing.Size(212, 54);
			this.buttonAuth.TabIndex = 5;
			this.buttonAuth.Text = "   Авторизоваться";
			this.buttonAuth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonAuth.Textcolor = System.Drawing.Color.White;
			this.buttonAuth.TextFont = new System.Drawing.Font("Century Gothic", 12.75F);
			this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
			// 
			// AuthorizationsControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.Controls.Add(this.buttonAuth);
			this.Controls.Add(lableNoAcc);
			this.Controls.Add(labelAuthorizationsMain);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxUserName);
			this.Name = "AuthorizationsControl";
			this.Size = new System.Drawing.Size(530, 292);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxUserName;
		private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxPassword;
		private Bunifu.Framework.UI.BunifuFlatButton buttonAuth;
	}
}