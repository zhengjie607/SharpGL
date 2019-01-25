using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;

namespace template
{
  public  class Camera
    {
        public Camera(OpenGL g)
        {
            gl = g;
            mPos = new Vector3f(154.06f, -2.116f,188.02f);
            mViewCenter = new Vector3f(153.99f, -1.1557f,187.7595f);
            mUp = new Vector3f(0.0125f, -0.062f, 1.00f);
            cameraHeight = 270;
            cameraWidth = 480;
            lightPos = mPos-mViewCenter;
            
        }
        public void Pitch(float angle)//上下旋转摄像机
        {
            Vector3f viewDirection = mViewCenter - mPos;
           viewDirection.Normalize();
            Vector3f rightDirection = viewDirection.Cross(mUp);
            rightDirection.Normalize();
            Vector3f newviewDirection = RotateAxle(viewDirection , angle, rightDirection.X, rightDirection.Y, rightDirection.Z);
            mUp = RotateAxle(mUp, angle, rightDirection.X, rightDirection.Y, rightDirection.Z);
            mPos = mViewCenter - newviewDirection;
            lightPos = mPos - mViewCenter;
        }
        public void Yaw(float angle)//左右旋转摄像机
        {
            Vector3f viewDirection = mViewCenter - mPos;
            Vector3f newviewDirection = RotateAxle(viewDirection, angle, mUp.X, mUp.Y, mUp.Z);
            
            mPos = mViewCenter - newviewDirection;
            lightPos = mPos - mViewCenter;
        }
   
        public Vector3f RotateAxle(Vector3f viewDirection, float angle, float x, float y, float z,float cx=0.0f,float cy=0.0f,float cz=0.0f)
        {
            Vector3f newDirection = new Vector3f(0, 0, 0);
            float C = Convert.ToSingle(Math.Cos(angle * Math.PI / 180));
            float S = Convert.ToSingle(Math.Sin(angle * Math.PI / 180));
            newDirection.X = viewDirection.X * (x * x + (1 - x * x) * C) + viewDirection.Y * (x * y * (1 - C) - z * S) + viewDirection.Z * (x * z * (1 - C) + y * S) + (1 - C) * (1 - x * x) * cx - (x * y - x * y * C - z * S) * cy - (x * z - x * z * C + y * S) * cz;
            newDirection.Y = viewDirection.X * (x * y * (1 - C) + z * S) + viewDirection.Y * (y * y + (1 - y * y) * C) + viewDirection.Z * (y * z * (1 - C) - x * S) + (1 - C) * (1 - y * y) * cy - (x * y - x * y * C + z * S) * cx - (y * z - y * z * C - x * S) * cz;
            newDirection.Z = viewDirection.X * (x * z * (1 - C) - y * S) + viewDirection.Y * (y * z * (1 - C) + x * S) + viewDirection.Z * (z * z + (1 - z * z) * C) + (1 - C) * (1 - z * z) * cz - (x * z - x * z * C - y * S) * cx - (y * z - y * z * C + x * S) * cy;
            return newDirection;
        }
      
        /// <summary>
        /// 平移相机
        /// </summary>
        /// <param name="deltax">左右平移距离</param>
        /// <param name="deltay">上下平移距离</param>
       public void MoveLeftandRight(float deltax, float deltay)
        {
            Vector3f forwardDirection = mViewCenter - mPos;
            forwardDirection.Normalize();
            Vector3f rightDirection = forwardDirection.Cross(mUp);
            rightDirection.Normalize();
            Vector3f delta = rightDirection * deltax;
            Vector3f deltaY = mUp * deltay;
            mPos = mPos - delta+ deltaY;
            mViewCenter = mViewCenter - delta+ deltaY;
            lightPos = mPos - mViewCenter;
        }
      
        public void setLight(Materials m)
        {
            float[] light_position = { lightPos.X, lightPos.Y, lightPos.Z, 0.0f };//齐次坐标，最后一位是前三个的分母，如果为0，代表无穷远，方向光
            float[] white_light = { 1.0f, 1.0f, 1.0f, 1.0f };   // 光的颜色
            
            gl.LoadIdentity();
            gl.ClearColor(0.0f, 0.0f,0.0f, 0.0f);  //背景色
            gl.ShadeModel(OpenGL.GL_SMOOTH);           //多变性填充模式

            //材质属性
            gl.Material(OpenGL.GL_FRONT, OpenGL.GL_SPECULAR, m.specular);
            gl.Material(OpenGL.GL_FRONT, OpenGL.GL_SHININESS, m.shininess);//高光指数
            gl.Material(OpenGL.GL_FRONT, OpenGL.GL_DIFFUSE, m.diffuse);

            //灯光设置
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_POSITION, light_position);
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_DIFFUSE, white_light);   //散射光属性
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_SPECULAR, white_light);  //镜面反射光
            gl.LightModel(OpenGL.GL_LIGHT_MODEL_AMBIENT, m.ambient_light);  //环境光参数

            gl.Enable(OpenGL.GL_LIGHTING);   //开关:使用光。这里开启的不是光，而是开启使用光照的算法
            gl.Enable(OpenGL.GL_LIGHT0);     //打开0#灯
            gl.Enable(OpenGL.GL_DEPTH_TEST); //打开深度测试
        }
        public void Update()
        {
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
            gl.Ortho(-cameraWidth, cameraWidth, -cameraHeight, cameraHeight, -540, 540);//正交投影，前两个参数是左右距离，中间两个是上下距离，最后两个是最近最远距离，眼睛必须位于之间。
            gl.LookAt(mPos.X, mPos.Y, mPos.Z, mViewCenter.X, mViewCenter.Y, mViewCenter.Z, mUp.X, mUp.Y, mUp.Z);
        }

      public   Vector3f mPos, mViewCenter, mUp;
        public float cameraWidth, cameraHeight;
        Vector3f lightPos;
        OpenGL gl;
    }
}
