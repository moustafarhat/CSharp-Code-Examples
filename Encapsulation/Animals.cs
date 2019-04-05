using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animals
    {
        private string privateVariable;
        public string PublicVariable;
        protected string ProtectedVaraible;
        internal string InternalVariable;

        private void TrainAnimalPrivate()
        {}
        public void TrainAnimalPublic()
        {}
        protected void TrainAnimalProtected()
        {}
        internal void TrainAnimalInternal()
        {}
    }

    class Dogs : Animals 
    {
        Dogs dog = new Dogs();

        void FeedDog()
        {
            
        }
    }

    class Cats
    {
        Animals animal = new Animals();

        void FeedCat()
        {
            
        }
    }
}
