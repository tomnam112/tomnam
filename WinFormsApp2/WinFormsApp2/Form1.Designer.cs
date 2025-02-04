using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

private void InitializeComponent(SizeF AutoScaleDimensions)
{
    btnAdd = new Button();
    tbGPAx = new TextBox();
    tbInputGPA = new TextBox(); // เปลี่ยนชื่อให้สื่อความหมาย
    label1 = new Label();
    label2 = new Label();
    SuspendLayout();

    // 
    // btnAdd
    // 
    btnAdd.Location = new Point(438, 53);
    btnAdd.Name = "btnAdd";
    btnAdd.Size = new Size(171, 79);
    btnAdd.TabIndex = 0;
    btnAdd.Text = "คำนวณ GPAx";
    btnAdd.UseVisualStyleBackColor = true;

    // 
    // tbGPAx
    // 
    tbGPAx.Location = new Point(132, 105);
    tbGPAx.Name = "tbGPAx";
    tbGPAx.Size = new Size(172, 27);
    tbGPAx.TabIndex = 1;
    tbGPAx.ReadOnly = true; // ห้ามแก้ไขค่าผลลัพธ์

    // 
    // tbInputGPA
    // 
    tbInputGPA.Location = new Point(132, 53);
    tbInputGPA.Name = "tbInputGPA";
    tbInputGPA.Size = new Size(172, 27);
    tbInputGPA.TabIndex = 2;

    // 
    // label1
    // 
    label1.AutoSize = true;
    label1.Location = new Point(22, 53);
    label1.Name = "label1";
    label1.Size = new Size(93, 20);
    label1.TabIndex = 3;
    label1.Text = "ใส่คะแนน GPA";

    object label2 = null;
    // 
    // label2
    // 
    label2.AutoSize = true;
    label2.Location = new Point(22, 105);
    label2.Name = "label2";
    label2.Size = new Size(43, 20);
    label2.TabIndex = 4;
    label2.Text = "GPAx";

    // 
    // Form1
    // 
    AutoScaleDimensions = new SizeF(8F, 20F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(701, 249);
    Controls.Add(label2);
    Controls.Add(label1);
    Controls.Add(tbInputGPA);
    Controls.Add(tbGPAx);
    Controls.Add(btnAdd);
    Name = "Form1";
    Text = "โปรแกรมคำนวณ GPAX";
    ResumeLayout(false);
    PerformLayout();
}

private Button btnAdd;
private TextBox tbGPAx;
private TextBox tbInputGPA;
private Label label1;
private Label label2;

