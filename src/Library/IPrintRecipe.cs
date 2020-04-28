namespace Full_GRASP_And_SOLID.Library
{
    //se crea interfaz IprintRecipe para cumplir con el patron de Polimorfismo,
    //al definir dos clases que lo implementan (FilePrinter y ConsolePrinter).
    
    public interface IPrintRecipe
    {
        void PrintRecipe(Recipe recipe);
    }
}