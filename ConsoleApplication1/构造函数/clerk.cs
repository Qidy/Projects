using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数
{

    public enum Gender
    {
            男,
            女
    }
        
    class clerk
    {
        //声明字段
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //选择_gender 按下Crtl+R后再按Ctrl+E弹出封装，弹出字段对应的属性
        private Gender _gender;
        public Gender Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }
        private string _department;
        public string Department
        {
            get
            {
                return _department;
            }

            set
            {
                _department = value;
            }
        }
        private int _workyears;
        private string v1;
        private Gender 男;
        private int v2;
        private string v3;

        public int Workyears
        {
            get
            {
                return _workyears;
            }

            set
            {
                _workyears = value;
            }
        }

        

        public void write()
        {
            Console.WriteLine("我叫{0}，我是{1}生，我今年{2}岁了，我在{3}部门任职，我工作{4}年了", this.Name,this.Gender,this.Age,this.Department,this.Workyears);//也可以使用this._name, this._gender, this._age, this._department, this._workyears
        }

        public clerk(string name,Gender gender,int age,string department, int   workyears)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Department = department;
            this.Workyears = Workyears;
        }

        public clerk(string v1, Gender 男, int v2, string v3)
        {
            this.v1 = v1;
            this.男 = 男;
            this.v2 = v2;
            this.v3 = v3;
        }

        public clerk()
        {

        }

        //析构函数以~符号开始
        ~clerk()
        {
            Console.WriteLine("我是析构函数，看声明时候调用");
            Console.ReadKey();
        }
    }
}
