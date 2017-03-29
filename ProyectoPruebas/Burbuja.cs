namespace ProyectoPruebas
{
    public class Burbuja
    {
        public int[] ordenar(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if(arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }
    }
}
