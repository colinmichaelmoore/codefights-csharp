int[][] rotateImage(int[][] a) {

int[][] b = new int[a.Length][];
    
    for(var x = 0; x < b.Length; x++){
        b[x] = new int[a.Length];
    }
    
  
    for (var i = 0; i < a.Length; i++){
        var length = a.Length - 1;
        for (var j = 0; j < a.Length; j++){
            
            b[i][j] = a[length][i];
            length--;
            
        }
    }

    
   
    
    return b;
}
