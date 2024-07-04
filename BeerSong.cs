using System;
using System.Linq;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown) =>
        Enumerable.Range(startBottles - (takeDown + 1), takeDown).Aggregate("", ((recite, next) => 
                ((next != startBottles) ? "\n\n" : "") 
                + (next > 0 ? next : "No more")
                + " bottle"
                + (next != 1 ? "s" : "")
                + " of beer on the wall, " 
                + (next > 0 ? next : "no more")
                +  " bottle"
                + (next != 1 ? "s" : "")
                +  " of beer.\n"
                + (next > 1 
                      ? "Take one down and pass it around" 
                      : next == 1 
                          ? "Take it down and pass it around" 
                          : "Go to the store and buy some more") 
                + ", "
                + (next > 1 
                      ? next - 1 
                      : next == 1 
                          ? "no more" 
                          : 99)
                + " bottle"
                + (next != 2 ? "s" : "") 
                +  " of beer on the wall."
                + recite
            ));
}