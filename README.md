1. 2 players (Choose names?)
2. choose/input rock, paper, or scissors
3. check match up
  * rock vs scissors = rock wins
    * if (p1 == rock) {
        if (p2 == scissors){
          p1 wins
        } else {p2 wins}
    }
  * paper vs rock = paper wins
  * scissors vs paper = scissors wins
4. determine winner
5. best two out of three?

Dictionary<string, string> rps = new Dictionary<string, string>() { {"rock", "scissors"}, {"paper", "rock"}, {"scissors", "paper"} };