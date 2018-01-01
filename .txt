int firstDuplicate(int[] a) {
    bool[] x = new bool[a.Length]; //Boolean array the same size as the target int array    
    for(var i = 0; i < a.Length; i++){  //Iterate the 'a' array
            if(x[a[i] - 1] == false)   //using the 'a' array and indicie determine if the coorisponding element in x is false
                x[a[i] - 1] = true;    //Make it true to mark that the element has been seen before
            else 
            return a[i];   	       //Return the duplicate     
    }
    return -1; //No duplicate was found and return -1
}