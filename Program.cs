
void FuncionLLamadoraA()
    {
        Dividir(1,1);
    }
void FuncionLLamadoraB()
    {
        Dividir(3,0);
    }
void Dividir(int a,int b)
    {
        try
        {
            int c = a/b;
        }
        catch (DivideByZeroException ex)
        {
            throw  new DivideByZeroException("No se puede dividir en cerp pibe"+ ex);
            //Informar cual de las dos funciones ocasionó el error
        }
    }