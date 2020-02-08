class Battleship {
	constructor(scheme, input) {
		this.battlefield = {
            'A': [],
            'B': [],
            'C': [],
            'D': [],
            'E': []
        }
		this.scheme = scheme;
		this.input = input;
		for (let key in this.battlefield) {
            for(let i = 0; i < 5; i++){
                if(this.isShip(key, i)) {
                    if(this.isBombed(key, i))
                        this.battlefield[key][i] = '☀';
                    else this.battlefield[key][i] = '●';
                }
                else {
                    if(this.isBombed(key, i))
                        this.battlefield[key][i] = '☼';
                    else this.battlefield[key][i] = '○';
                }
            }
        }
		this.calc();
	}
		calc()
    {
        this.s = 0;
        this.p = 0;
        let array = this.board();
        for (let i = 0; i < array.length; i+=2) 
            for(let j = 0; j < array[i].length; j+=2) 
                if(array[i][j] == '☀'){
                    if(this.isNearSunk(array, i, j)){
                        this.s++;
                        this.p+=2;
                    }
                    else this.p++;
                }
    }
    isShip(letter, column)
    {
        return this.scheme.indexOf(letter + (column + 1)) != -1;
    }
    isBombed(letter, column)
    {
        return this.input.indexOf(letter + (column + 1)) != -1;
    }
    board() {
        let array = [];
        for (let key in this.battlefield)
            array.push(this.battlefield[key]);
        return array;
    }
		hits()
		{
			let count = 0;
         for (let key in this.battlefield) 
             for(let i = 0; i < this.battlefield[key].length; i++)
                 if(this.battlefield[key][i] == '☀')
                     count++;
         return count;
		}
	isNearSunk(array, i, j)
    {
        return i != 0 && array[i-1][j] == '☀' || i != array.length - 1 && array[i+1][j] == '☀' ||
        j != 0 && array[i][j-1] == '☀' || j != array.length - 1 && array[i][j+1] == '☀';
    }
		sunk()
	{
		return this.s;
	}
	points()
	{
		return this.hits() + this.s*2;
	}
}