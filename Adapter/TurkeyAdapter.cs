namespace Adapter
{
    /// <summary>
    /// 适配器对象，实现目标接口，组合被适配器对象
    /// 用Turkey来冒充Duck(对象适配器:使用组合来适配被适配者)
    /// (类适配器：使用继承，在支持多重继承语言中可用)
    /// </summary>
    public class TurkeyAdapter : IDuck
    {
        private readonly ITurkey _turkey;
        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public void Quack()
        {
            _turkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }
    }
}