class Shiritori {
    constructor ()  {
      this.words = []
      this.game_over = false;
    }

    play(word) {
      console.log("Your word: ", word);

      if(this.words.some((one_word) => {
        return one_word === word;
      })){
        this.game_over = true;
        console.log("Invalid word", word, "already used");
        return "game over";
      }

      if(this.words && this.words.length > 0) {
        const lastWord = this.words[this.words.length-1];
        if(lastWord[lastWord.length-1]!==word[0]){
          this.game_over = true;
          console.log("Invalid word - your starting character does not match the previous word end character");
          return "game over";
        }
      }
      console.log("Your word is valid");
      console.log();
      this.words.push(word);
      return this.words;
      

  
    }

    //
    restart() {
      this.words = []
      this.game_over = false;
      return "game restarted";
    }
  }

my_shiritori = new Shiritori();
my_shiritori.play("apple");
my_shiritori.play("eat");
my_shiritori.play("tea");
my_shiritori.play("eye");
my_shiritori.play("eat");