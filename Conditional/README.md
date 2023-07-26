# 2023-07-26

## 제어문

`if` : 조건문과 같이 사용. `else if` / `else` 와 같이 사용 가능. `if`문 안에 `if`를 또 넣는건 별로인듯..

`switch` : 변수, `case`와 같이 사용. 특정 선택지중 하나 고를때 사용하면 좋다.

`for` : 초기문, 반복문, 조건문과 같이 사용. 특정 구간을 반복해야할때 사용하면 좋다.

`while` : 조건문과 같이 사용. 조건문에 제한을 두지 않으면 무한실행 주의.

`do while` : `do`를 실행하고 `while` 조건동안 반복. 첫 `do`는 무조건 실행되기 때문에 `while`의 조건문에 들어갈 변수를 반복문에서 할당해야할때 사용.



## 배열

`string[] mouse = new string[3];` : mouse 라는 이름을 가진 3칸짜리 배열을 선언

`mouse[0] = "logitech"` : 배열의 첫번째 칸에 logitech 이라는 데이터를 저장

`Console.WriteLine(mouse[0]);` : 첫번째 칸에 저장한 logitech 출력

`int[] mouse = new int[4];` : 정수 배열

`float[] mouse = new float[4];` : 실수 배열

배열의 타입이 다르면 저장 불가능.

변수를 사용해서 배열의 공간갯수를 저장/사용 가능. ex) for문 + `mouse[i]`

`foreach` : 조건문을 사용하지 않고 배열을 처음부터 끝까지 반복할때 사용.

`foreach(string mouse in mice)` 반복변수의 타입은 배열의 타입과 일치해야 함.

`string[] mouse = new string[3] {"Logitech", "Razer", "Steelseries"};` : 배열을 생성하면서 초기화 시키려면 중괄호를 사용하면 된다.
*주의 : 생성된 배열 크기에 맞게 데이터를 저장해야함.
