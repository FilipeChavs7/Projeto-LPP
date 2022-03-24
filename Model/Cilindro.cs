namespace Projeto_LPP
{
    public class Cilindro : Forma
    {
        public double calculaVolume()
        {
            return 0;
        }
        public virtual double calculaArea(double raio, double altura)
        {
            var areaBase = PI*raio*raio;
            var areaLateral = 2*PI*raio*altura;
            return 2*areaBase + areaLateral;
        }
        public virtual string toString()
        {
            return base.toString();
        }
    }
}