namespace Monostate
{
    /// <summary>
    /// Monostate是另外一种获取对象单一性的方法
    /// Singleton强制结构上的单一性，防止创建多个对象实例
    /// Monostate强制行为上的单一性(通过使用同一内部变量)
    /// </summary>
    public class Monostate
    {
        private static int _x;
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
    }
}