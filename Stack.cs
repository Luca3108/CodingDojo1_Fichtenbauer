using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack<T>
    {

        private StackObject<T> currentObject;  //Es ist nur notwendig das currentObject zu speichern, da dieses für sich selbst weiß welches nachfolgt usw.



        public void Push(T objectPush)
        {
            if (currentObject == null)
            {
                currentObject = new StackObject<T>() { Object = objectPush, followingObject = null };

            }
            else
            {
                StackObject<T> tmp = new StackObject<T>() { Object = objectPush, followingObject = currentObject };
                currentObject = tmp;
            }
        }


        // "Deletes" the Last In Object and sets the CurrentObject on the Following Object
        public T Pop()
        {
            if (currentObject != null)
            {
                T temp = currentObject.Object;
                currentObject = currentObject.followingObject;
                return temp;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public T Peek()
        {
            if(currentObject != null)
            {
                return currentObject.Object;
            }
            else
            {
                throw new Exception();
            }
        }



    }
}
