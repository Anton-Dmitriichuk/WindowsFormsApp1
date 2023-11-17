
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Contract_page = new System.Windows.Forms.TabPage();
            this.client_date_of_birth = new System.Windows.Forms.TextBox();
            this.add_client_button = new System.Windows.Forms.Button();
            this.client_phone_text = new System.Windows.Forms.Label();
            this.client_address_text = new System.Windows.Forms.Label();
            this.client_date_of_birth_text = new System.Windows.Forms.Label();
            this.client_patronymic_text = new System.Windows.Forms.Label();
            this.client_num_passport_text = new System.Windows.Forms.Label();
            this.client_contingent_text = new System.Windows.Forms.Label();
            this.client_surname_text = new System.Windows.Forms.Label();
            this.client_series_passport_text = new System.Windows.Forms.Label();
            this.client_name_text = new System.Windows.Forms.Label();
            this.client_phone = new System.Windows.Forms.TextBox();
            this.client_address = new System.Windows.Forms.TextBox();
            this.client_num_passport = new System.Windows.Forms.TextBox();
            this.client_patronymic = new System.Windows.Forms.TextBox();
            this.client_series_passport = new System.Windows.Forms.TextBox();
            this.client_contingent = new System.Windows.Forms.TextBox();
            this.client_surname = new System.Windows.Forms.TextBox();
            this.client_name = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Contract_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Contract_page);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1448, 519);
            this.tabControl1.TabIndex = 0;
            // 
            // Contract_page
            // 
            this.Contract_page.Controls.Add(this.textBox1);
            this.Contract_page.Controls.Add(this.client_date_of_birth);
            this.Contract_page.Controls.Add(this.add_client_button);
            this.Contract_page.Controls.Add(this.client_phone_text);
            this.Contract_page.Controls.Add(this.client_address_text);
            this.Contract_page.Controls.Add(this.client_date_of_birth_text);
            this.Contract_page.Controls.Add(this.client_patronymic_text);
            this.Contract_page.Controls.Add(this.client_num_passport_text);
            this.Contract_page.Controls.Add(this.client_contingent_text);
            this.Contract_page.Controls.Add(this.client_surname_text);
            this.Contract_page.Controls.Add(this.client_series_passport_text);
            this.Contract_page.Controls.Add(this.client_name_text);
            this.Contract_page.Controls.Add(this.client_phone);
            this.Contract_page.Controls.Add(this.client_address);
            this.Contract_page.Controls.Add(this.client_num_passport);
            this.Contract_page.Controls.Add(this.client_patronymic);
            this.Contract_page.Controls.Add(this.client_series_passport);
            this.Contract_page.Controls.Add(this.client_contingent);
            this.Contract_page.Controls.Add(this.client_surname);
            this.Contract_page.Controls.Add(this.client_name);
            this.Contract_page.Location = new System.Drawing.Point(4, 22);
            this.Contract_page.Name = "Contract_page";
            this.Contract_page.Padding = new System.Windows.Forms.Padding(3);
            this.Contract_page.Size = new System.Drawing.Size(1440, 493);
            this.Contract_page.TabIndex = 0;
            this.Contract_page.Text = "ы";
            this.Contract_page.UseVisualStyleBackColor = true;
            // 
            // client_date_of_birth
            // 
            this.client_date_of_birth.Location = new System.Drawing.Point(404, 144);
            this.client_date_of_birth.Name = "client_date_of_birth";
            this.client_date_of_birth.Size = new System.Drawing.Size(174, 20);
            this.client_date_of_birth.TabIndex = 4;
            // 
            // add_client_button
            // 
            this.add_client_button.Location = new System.Drawing.Point(306, 365);
            this.add_client_button.Name = "add_client_button";
            this.add_client_button.Size = new System.Drawing.Size(283, 56);
            this.add_client_button.TabIndex = 3;
            this.add_client_button.Text = "Добавить пациента";
            this.add_client_button.UseVisualStyleBackColor = true;
            this.add_client_button.Click += new System.EventHandler(this.add_client_button_Click);
            // 
            // client_phone_text
            // 
            this.client_phone_text.AutoSize = true;
            this.client_phone_text.Location = new System.Drawing.Point(303, 316);
            this.client_phone_text.Name = "client_phone_text";
            this.client_phone_text.Size = new System.Drawing.Size(93, 13);
            this.client_phone_text.TabIndex = 1;
            this.client_phone_text.Text = "Номер телефона";
            // 
            // client_address_text
            // 
            this.client_address_text.AutoSize = true;
            this.client_address_text.Location = new System.Drawing.Point(295, 290);
            this.client_address_text.Name = "client_address_text";
            this.client_address_text.Size = new System.Drawing.Size(103, 13);
            this.client_address_text.TabIndex = 1;
            this.client_address_text.Text = "Адрес проживания";
            // 
            // client_date_of_birth_text
            // 
            this.client_date_of_birth_text.AutoSize = true;
            this.client_date_of_birth_text.Location = new System.Drawing.Point(312, 151);
            this.client_date_of_birth_text.Name = "client_date_of_birth_text";
            this.client_date_of_birth_text.Size = new System.Drawing.Size(86, 13);
            this.client_date_of_birth_text.TabIndex = 1;
            this.client_date_of_birth_text.Text = "Дата рождения";
            // 
            // client_patronymic_text
            // 
            this.client_patronymic_text.AutoSize = true;
            this.client_patronymic_text.Location = new System.Drawing.Point(342, 89);
            this.client_patronymic_text.Name = "client_patronymic_text";
            this.client_patronymic_text.Size = new System.Drawing.Size(54, 13);
            this.client_patronymic_text.TabIndex = 1;
            this.client_patronymic_text.Text = "Отчество";
            // 
            // client_num_passport_text
            // 
            this.client_num_passport_text.AutoSize = true;
            this.client_num_passport_text.Location = new System.Drawing.Point(307, 264);
            this.client_num_passport_text.Name = "client_num_passport_text";
            this.client_num_passport_text.Size = new System.Drawing.Size(91, 13);
            this.client_num_passport_text.TabIndex = 1;
            this.client_num_passport_text.Text = "Номер паспорта";
            // 
            // client_contingent_text
            // 
            this.client_contingent_text.AutoSize = true;
            this.client_contingent_text.Location = new System.Drawing.Point(333, 115);
            this.client_contingent_text.Name = "client_contingent_text";
            this.client_contingent_text.Size = new System.Drawing.Size(65, 13);
            this.client_contingent_text.TabIndex = 1;
            this.client_contingent_text.Text = "Контингент";
            // 
            // client_surname_text
            // 
            this.client_surname_text.AutoSize = true;
            this.client_surname_text.Location = new System.Drawing.Point(342, 63);
            this.client_surname_text.Name = "client_surname_text";
            this.client_surname_text.Size = new System.Drawing.Size(56, 13);
            this.client_surname_text.TabIndex = 1;
            this.client_surname_text.Text = "Фамилия";
            // 
            // client_series_passport_text
            // 
            this.client_series_passport_text.AutoSize = true;
            this.client_series_passport_text.Location = new System.Drawing.Point(310, 238);
            this.client_series_passport_text.Name = "client_series_passport_text";
            this.client_series_passport_text.Size = new System.Drawing.Size(88, 13);
            this.client_series_passport_text.TabIndex = 1;
            this.client_series_passport_text.Text = "Серия паспорта";
            // 
            // client_name_text
            // 
            this.client_name_text.AutoSize = true;
            this.client_name_text.Location = new System.Drawing.Point(369, 37);
            this.client_name_text.Name = "client_name_text";
            this.client_name_text.Size = new System.Drawing.Size(29, 13);
            this.client_name_text.TabIndex = 1;
            this.client_name_text.Text = "Имя";
            // 
            // client_phone
            // 
            this.client_phone.Location = new System.Drawing.Point(404, 313);
            this.client_phone.Name = "client_phone";
            this.client_phone.Size = new System.Drawing.Size(174, 20);
            this.client_phone.TabIndex = 0;
            // 
            // client_address
            // 
            this.client_address.Location = new System.Drawing.Point(404, 287);
            this.client_address.Name = "client_address";
            this.client_address.Size = new System.Drawing.Size(174, 20);
            this.client_address.TabIndex = 0;
            // 
            // client_num_passport
            // 
            this.client_num_passport.Location = new System.Drawing.Point(404, 261);
            this.client_num_passport.Name = "client_num_passport";
            this.client_num_passport.Size = new System.Drawing.Size(174, 20);
            this.client_num_passport.TabIndex = 0;
            // 
            // client_patronymic
            // 
            this.client_patronymic.Location = new System.Drawing.Point(404, 86);
            this.client_patronymic.Name = "client_patronymic";
            this.client_patronymic.Size = new System.Drawing.Size(174, 20);
            this.client_patronymic.TabIndex = 0;
            // 
            // client_series_passport
            // 
            this.client_series_passport.Location = new System.Drawing.Point(404, 235);
            this.client_series_passport.Name = "client_series_passport";
            this.client_series_passport.Size = new System.Drawing.Size(174, 20);
            this.client_series_passport.TabIndex = 0;
            // 
            // client_contingent
            // 
            this.client_contingent.Location = new System.Drawing.Point(404, 112);
            this.client_contingent.Name = "client_contingent";
            this.client_contingent.Size = new System.Drawing.Size(174, 20);
            this.client_contingent.TabIndex = 0;
            // 
            // client_surname
            // 
            this.client_surname.Location = new System.Drawing.Point(404, 60);
            this.client_surname.Name = "client_surname";
            this.client_surname.Size = new System.Drawing.Size(174, 20);
            this.client_surname.TabIndex = 0;
            // 
            // client_name
            // 
            this.client_name.Location = new System.Drawing.Point(404, 34);
            this.client_name.Name = "client_name";
            this.client_name.Size = new System.Drawing.Size(174, 20);
            this.client_name.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1440, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(658, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 519);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Contract_page.ResumeLayout(false);
            this.Contract_page.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Contract_page;
        private System.Windows.Forms.Label client_phone_text;
        private System.Windows.Forms.Label client_address_text;
        private System.Windows.Forms.Label client_patronymic_text;
        private System.Windows.Forms.Label client_num_passport_text;
        private System.Windows.Forms.Label client_surname_text;
        private System.Windows.Forms.Label client_series_passport_text;
        private System.Windows.Forms.Label client_name_text;
        private System.Windows.Forms.TextBox client_phone;
        private System.Windows.Forms.TextBox client_address;
        private System.Windows.Forms.TextBox client_num_passport;
        private System.Windows.Forms.TextBox client_patronymic;
        private System.Windows.Forms.TextBox client_series_passport;
        private System.Windows.Forms.TextBox client_surname;
        private System.Windows.Forms.TextBox client_name;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label client_date_of_birth_text;
        private System.Windows.Forms.Label client_contingent_text;
        private System.Windows.Forms.TextBox client_contingent;
        private System.Windows.Forms.Button add_client_button;
        private System.Windows.Forms.TextBox client_date_of_birth;
        private System.Windows.Forms.TextBox textBox1;
    }
}

