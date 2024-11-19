# 1번 문제

주어진 프로젝트 내에서 CubeManager 객체는 다음의 책임을 가진다
- 해당 객체 생성 시 Cube프리팹의 인스턴스를 생성한다
- Cube 인스턴스의 컨트롤러를 참조해 위치를 변경한다.

제시된 소스코드에서는 큐브 인스턴스 생성 후 아래의 좌표로 이동시키는 것을 목표로 하였다
- x : 3
- y : 0
- z : 3

제시된 소스코드에서 문제가 발생하는 `원인을 모두 서술`하시오.

## 답안
- public Vector3 SetPoint { get; set; } // set이 private 으로 설정되어 CubeManager에서 변경 불가능
- SetCubePosition(3, 0, 3); // 초기화가 되기전에 포지션을 설정해서 어웨이크에서 스타트로 내림
- _cubeSetPoint = _cubeController.SetPoint; // SetCubePosition이 나중에 호출되니 주석처리

