using System.Collections.Generic;

namespace Builder.Demo.Despues
{
    internal class Presentacion
    {
        private IConstructorPresentacion constructor;

        private IList<Diapositiva> diapositivas = new List<Diapositiva>();

        internal IConstructorPresentacion Constructor { get => constructor; set => constructor = value; }

        public void AgregarDiapositiva(Diapositiva diapositiva)
        {
            diapositivas.Add(diapositiva);
        }

        public void Exportar(IConstructorPresentacion constructor = null)
        {
            if(constructor == null)
            {
                constructor = this.constructor;
            }
            else
            {
                this.constructor = constructor;
            }

            constructor.AgregarDiapositiva(new Diapositiva("Copyright"));
            foreach (var diapositiva in diapositivas)
            {
                constructor.AgregarDiapositiva(diapositiva);
            }
        }
    }
}
