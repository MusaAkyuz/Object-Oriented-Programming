class Solution {
    public boolean arrayStringsAreEqual(String[] word1, String[] word2) {
        
        /*
        Mission
        Given two string arrays word1 and word2, return true if the two arrays represent the same string, 
        and false otherwise.
        A string is represented by an array if the array elements concatenated in order forms the string.
        */
        
        return String.join("", word1).equals(String.join("", word2));
    }
}