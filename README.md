# AI를 이용한 신호등 제어 시스템
  
  
## 0. 개요
AI를 이용한 신호등 제어 시스템을 만드는 프로젝트입니다.  
이 레포지토리는 유니티를 이용해 차량과 행인들이 돌아다니는 가상 환경을 만들고, 시뮬레이션 하기 위한 파일들이 저장되어 있습니다.  
YOLOv5를 이용한 사물 감지는 https://lab.hanium.or.kr/22_HF345/22_hf345 해당 레포지토리를 참고해주세요.

- 사용 기술 스택  
<img src="https://img.shields.io/badge/C Sharp-239120?style=for-the-badge&logo=C Sharp&logoColor=white">  
<img src="https://img.shields.io/badge/Unity-000000?style=for-the-badge&logo=Unity&logoColor=white">

## 1. 설명
![UnityProject](https://lab.hanium.or.kr/22_HF345/trafficsimulation/raw/master/README_files/UnityProject.png)
1. 차량이 도로를 따라 움직이는 AI를 구현합니다.
2. 실제 도로에서 사용되고 있는 신호등의 신호 체계를 구현합니다.
3. 라즈베리파이, YOLOv5를 이용해 만든 최적의 신호등 알고리즘을 유니티에서 구현합니다.
4. 2번과 3번중 어느 것이 더 효율적인지 비교합니다.

## 2. 구현 목표
### 1. 신호등 동작 ✅
<img src = "https://lab.hanium.or.kr/22_HF345/trafficsimulation/raw/master/README_files/plan1_1.png" width="45%">
<img src = "https://lab.hanium.or.kr/22_HF345/trafficsimulation/raw/master/README_files/plan1_2.png" width="45%">

정해진 시간에 따라 신호등의 신호가 자동으로 변경되는 것을 확인

### 2. 신호등 신호에 맞추어 차량 이동 ✅  
[![Video Label](http://img.youtube.com/vi/37I2fnLaaOU/0.jpg)](https://www.youtube.com/watch?v=37I2fnLaaOU)  
신호등의 신호에 따라 차량이 멈추고, 움직이는 것을 확인

### 3. 2차로보다 더 큰 도로 만들기 
Working on it...