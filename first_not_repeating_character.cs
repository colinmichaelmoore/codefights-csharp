char firstNotRepeatingCharacter(string s) {
    
    int[,] alphabet = new int[26,2];
  
    for(var i = 0; i < s.Length; i++){
      
        alphabet[s[i] - 97, 0] += 1;
        if (alphabet[s[i] - 97, 1] == 0){
            alphabet[s[i] - 97, 1] = i;
        }
        
    }
    
    
    for(var j = 0; j < s.Length; j++){
                    
        if (alphabet[s[j] - 97, 0] == 1){
            var index = alphabet[s[j] - 97, 1];
            return s[index];
        }
    }
        
    
        
    
    
    return '_';
}
