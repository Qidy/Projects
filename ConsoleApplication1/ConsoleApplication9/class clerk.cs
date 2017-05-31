using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    public enum gender
    {
        男生,
        女生
    }


    //字段的命名规范使用_camelcase
    //字段可以存放多个值，变量只能存放一个值，字段是用来存放数据
    //属性的作用：保护字段，对字段的取值与赋值进行限定
    //说明：属性往往被声明在字段的下方，并将字段私有化
    //属性的格式  public[对应字段类型] 属性名
    /*{
     * get[return _name};    _name   可用于对取值进行限定
     * set{_name=valuename}  value    可用于对赋值进行限定
     * }
     * 有了属性往往通过属性来访问字段
     * 属性通常声明为public 字段声明为private
     * 在外部访问类中的字段，都是通过属性来实现的
     * 属性为小扳手，方法为方块
     * 
     * 通常将get于set成为访问器
     * 属性分为：
     * 读写   同时包含get与set
     * 只读   只包含get
     * 只写   只包含set
     * 自动   get;
     *        set;
     *        
     *      get属性访问器用于返回属性值
     *      set属性
     *        
     */
    class class_clerk
    {
        private string _name;
        public string Name
        {
            get;
            set;
        }
        private char _gender;
        public char Gender
        {
            get
            {
                if (_gender != '男' || _gender != '女') _gender = '男';
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
                if (value < 0 || value > 120) value = 0;
                _age = value;
            }
        }
        private string _department;
        public string Department
        {
            get;
            set;
        }
        private int _workyears;
        public int Workyears
        {
            get;
            set;
        }

        //静态方法只能访问静态成员
        //实例方法可以访问任何方式的成员
        public void write()
        {
            Console.WriteLine("我叫{0}，我是{1}生，我今年{2}岁了，我在{3}部门任职，我工作{4}年了", Name, Gender, Age, Department, Workyears);//也可以使用this._name, this._gender, this._age, this._department, this._workyears
        }
    }


}
