// В JavaScript класс – это разновидность функции.
class MyClass {

    // Тут мы можем инициализировать объект
    // 1) Код функции берётся из метода constructor (она будет пустой, если такого метода нет).
    constructor(name) {
        this.name = name
    }

    // 2) Cохраняет все методы, такие как sayHi, в MyClass.prototype
    sayHi() {
        console.log(this.name);
    }

    // Геттеры-сеттеры, другие сокращения
    get name() {
        return this._user;
    }

    set name(value) {
        if(value.length < 4) {
            console.log("Имя слишком короткое");
            return;
        }
        this._name = value;
    }

    // Внутри классов запятые не требуются.
}

let user = new MyClass("Ihor");
user.sayHi();
console.log(typeof MyClass);

user = new MyClass("");