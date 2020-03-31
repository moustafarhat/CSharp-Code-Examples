namespace Inheritance
{
    internal class Animals
    {
        private string privateVariable;
        public string PublicVariable;
        protected string ProtectedVaraible;
        internal string InternalVariable;

        private void TrainAnimalPrivate()
        { }

        public void TrainAnimalPublic()
        { }

        protected void TrainAnimalProtected()
        { }

        internal void TrainAnimalInternal()
        { }
    }

    internal class Dogs : Animals
    {
        private Dogs dog = new Dogs();

        private void FeedDog()
        {
        }
    }

    internal class Cats
    {
        private Animals animal = new Animals();

        private void FeedCat()
        {
        }
    }
}