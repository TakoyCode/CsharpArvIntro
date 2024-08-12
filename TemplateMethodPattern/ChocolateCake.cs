namespace TemplateMethodPattern
{
    internal class ChocolateCake : Cake
    {
        public ChocolateCake()
        {
            _treatments = new Treatment[]
            {
                new BakeInOvenTreatment(),
            };
        }

        protected override void GetIngredients()
        {
            
        }

        protected override void PreCool()
        {
            Wait();
        }

        protected override void MakeParts()
        {
            CutInHalf(0);
            CutInHalf(45);
            CutInHalf(90);
        }
    }
}
