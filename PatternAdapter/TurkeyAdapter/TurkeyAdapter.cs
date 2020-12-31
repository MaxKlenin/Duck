using PatternStrategy.DuckType;
using PatternAdapter.Turkey;

namespace PatternAdapter.TurkeyAdapter
{
    public class TurkeyAdapter : BaseDuck
    {
        private readonly BaseTurkey _turkey; 

        public TurkeyAdapter(BaseTurkey turkey)
        {
            _turkey = turkey;
        }

        public override void MakeQuack()
        {
            _turkey.MakeGobble();
        }

        public override void MakeFly()
        {
            _turkey.MakeFly();
        }

        public override void MakeWalk()
        {
            _turkey.MakeWalk();
        }

        public override void MakeSwim()
        {
            _turkey.MakeSwim();
        }

        public override void ShowName()
        {
            _turkey.ShowName();
        }

        public override void ShowInfo()
        {
            _turkey.MakeFly();
            _turkey.MakeGobble();
            _turkey.MakeSwim();
            _turkey.MakeWalk();
            _turkey.ShowName();
        }
    }
}
