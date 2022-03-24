namespace Projeto_LPP
{
    public class Circulo : Forma
    {

        public Circulo()
        {
        }
        public virtual double calculaArea(double raio)
        {
            return PI*raio*raio;
        }
        public virtual string toString()
        {
            return base.toString();
        }
    }
}