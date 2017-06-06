using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自定义异常类
{
    class MyException:Exception
    {

        //定义异常类型警告信息内容:base(message)
        public MyException(string message):base(message)
        {

        }

    }
}
