namespace TemplateMethodPattern
{
    internal abstract class Food
    {
        protected Treatment[] _treatments;

        public virtual void Make()
        {
            GetIngredients();
            PrepareIngredients();
            MixIngredients();
            foreach (var treatment in _treatments)
            {
                treatment.Do(this);
            }
            PreCool();
            MakeParts();
            PostCool();
            Wrap();
        }

        protected abstract void GetIngredients();
        protected abstract void PrepareIngredients();
        protected abstract void MixIngredients();
        protected abstract void PreCool();
        protected abstract void MakeParts();
        protected abstract void PostCool();
        protected abstract void Wrap();
    }
}
