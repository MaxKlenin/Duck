using PatternStrategy.DuckType;
using PatternAdapter.Turkey;

namespace PatternAdapter.TurkeyAdapter
{
    public class TurkeyAdapter : BaseDuck
    {
        BaseTurkey turkey; 
        public TurkeyAdapter(BaseTurkey turkey)
            : base () 
        {
            this.turkey = turkey;
        }
        public override void MakeQuack()
        {
            turkey.MakeGobble();
        }
        public override void MakeFly()
        {
            turkey.MakeFly();
        }
        public override void MakeWalk()
        {
            turkey.MakeWalk();
        }
        public override void MakeSwim()
        {
            turkey.MakeSwim();
        }
        public override void ShowInfo()
        {
            turkey.MakeFly();
            turkey.MakeGobble();
            turkey.MakeSwim();
            turkey.MakeWalk();
        }
    }
}
