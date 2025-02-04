# โปรแกรมคำนวณ GPAX (WinFormsApp2)
## 📌 รายละเอียด
- โปรแกรมรับค่า **GPA** ที่ผู้ใช้กรอก
- กดปุ่ม **เพิ่ม GPA** แล้วโปรแกรมจะคำนวณค่า **GPAX**
- ใช้ **WinForms + C# + OOP** (แยก Business Logic ออกจาก UI)

## 🖼 รูป UI
![UI ของโปรแกรม]

## 📌 UML Class Diagram
```plantuml
@startuml
class Student {
  - double gpaSum
  - int count
  - double minGPA
  + void SetGPA(double gpa)
  + double GetGPAX()
  + double GetMinGPA()
}
class Form1 {
  - Student student
  + void BtnAdd_Click()
}
Form1 --> Student : ใช้งาน
@enduml
