double[,] mat = new double[2, 3];//2 linhas, 3 colunas

Console.WriteLine(mat.Length);//quantidade de elementos no total
Console.WriteLine(mat.Rank);//quanto é a primeira dimensão (linhas)
Console.WriteLine(mat.GetLength(0));//Dimensão 0 (primeira) tem tamanho 2 (quantida de linhas)
Console.WriteLine(mat.GetLength(1));//Dimensão 1 (segunda) tem tamanho 3 (quantida de colunas)