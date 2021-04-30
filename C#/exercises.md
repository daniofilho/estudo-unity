# 1

Crie variáveis para representar os seguintes itens:
a. Número de vidas
b. Número de moedas
c. Nome
d. Energia

```csharp
  int lifes = 10;
  int coins = 100;
  string name = "John Doe";
  float energy = 20.5f;
```

---

# 2

Faça uma soma usando os valores inteiros de duas variáveis (valor1 e valor2), coloque o resultado em uma terceira variável (result) e exiba no console seu resultado.

```csharp
class Study {
float energy = 20.5f;
  int value1 = 5;
  int value2 = 10;

  void Start() {
    int value3 = value1 + value2;
  }

}
```

---

# 3

Crie uma estrutura condicional que exibe a palavra Unity se, e somente se a variável inteira (engine) for maior que 10.

```csharp
class Study {
  int engine = 15;

  void Start() {
    if(engine > 10) {
      print("Unity");
    }
  }

}
```

---

# 4.

Crie um laço de qualquer tipo que seja capaz de imprimir no console números de 0 (zero) até 10.

```csharp
class Study {

  void Start() {
    for(int i = 0; 0<=10; i++) {
      print(i);
    }
  }

}
```

---

# 5

Crie um vetor para guardar 5 nomes de vilões, depois imprima no console cada um dos nomes.

```csharp
class Study {

  string[] villains = new string[5];

  void Start() {

    villains[0] = "V1";
    villains[1] = "V2";
    villains[2] = "V3";
    villains[3] = "V4";
    villains[4] = "V5";

    for(int i = 0; i<5; i++) {
      print(villains[i]);
    }
  }

}
```

---

# 6

Crie uma lista contendo 10 elementos de qualquer tipo depois imprima cada elemento no console.

```csharp
class Study {

  List<int> elements = new List();

  void Start() {
    elements.Add(10);
    elements.Add(20);
    elements.Add(30);

    foreach(int val in elements)
      print(val);
    }
  }
}


```

---

# 7

Crie uma classe que represente um zumbi, todos seus atributos devem ser públicos.

```csharp
class Zombie {

  public int life;
  public int damage;

  // constructor
  public Zombie() {
    this.life = 10;
    this.damage = 2;
  }

}
```

---

# 8

Crie um objeto da classe zumbi e exiba no console cada atributo criado.

```csharp
class Zombie {

  public int life;
  public float damage;

  public Zombie() {
    this.life = 10;
    this.damage = 2f;
  }

}

class Study {

  Zombie zombie = new Zombie();

  void Start() {
    print(zombie.life);
    print(zombie.damage);
  }

}
```

---

# 9

Crie uma classe chamada zumbi_filho e faça com que ela herde da classe zumbi.

```csharp
class Zombie {

  public int life;
  public int damage;

  // ...
}

class ZombieSon : Zombie {
  //...
}
```

---

# 10

Usando polimorfismo crie um método chamado andar, dentro da classe zumbi_filho e zumbi, garanta que seremos capazes de sobrescrever esse método.

```csharp
class Zombie {

  public int life;
  public int damage;

  void Walk() {
    print('walking...');
  }

}

class zumbi_filho : Zombie {

  public override void walk() {
    print('really walking now...');
  }

}
```

---

# Bônus - Código mais completo com vários exemplos

```csharp
class Enemy {

  private int life;
  private int maxLife = 10;
  public string name;

  //get/set
  public int Life {
    get { return this.life; }
    set {
      if(value >= this.maxLife) {
        this.life = this.maxLife;
      } else {
        this.life = value;
      }
    }
  }

  void Walk() {
    print('walking...');
  }
}

class Zombie {
  private float damage;
  private List<int> inventory;

  public Zombie(int life) {
    base.life = life;
    this.damage = 2.5f;
    this.inventory= = new List(0,1,2,3);
  }
}

class Study {

  enum CustomType {Foo, Bar};
  private Zombie zombie = new Zombie(10);

  void Start() {
    CustomType customTestType = CustomType.Foo;

    zombie.Life = 8; //set zombie life
    print(zombie.Life); // get zombie life
  }

  void Update() {
    zombie.Walk();
  }

}
```
