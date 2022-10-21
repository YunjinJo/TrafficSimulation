# AI를 이용한 신호등 제어 시스템
  
  
## 0. 개요
AI를 이용한 신호등 제어 시스템을 만드는 프로젝트입니다.  
이 레포지토리는 유니티를 이용해 차량과 행인들이 돌아다니는 가상 환경을 만들고, 시뮬레이션 하기 위한 파일들이 저장되어 있습니다.  
YOLOv5를 이용한 사물 감지는 https://github.com/YunjinJo/yolov5_car_count 해당 레포지토리를 참고해주세요.

- 프로젝트 구성
  - 프로젝트 주최: 한이음 2022
  - 진행 기간: 2022.04.15 ~ 2022.11.30
  - 참여자: 한국공학대학교-조윤진, 한국공학대학교-최영재, 한국공학대학교-김민상
  - 사용 기술 스택  
<img src="https://img.shields.io/badge/C Sharp-239120?style=for-the-badge&logo=C Sharp&logoColor=white">  
<img src="https://img.shields.io/badge/Unity-000000?style=for-the-badge&logo=Unity&logoColor=white">

### 구현 결과
<img src="https://github.com/YunjinJo/TrafficSimulation/blob/master/README_files/Result_thumnail.png?raw=true">
<a href="https://www.youtube.com/watch?v=Z5d_juwLt5g">유튜브 링크</a>



## 1. 설명
![UnityProject](https://github.com/YunjinJo/TrafficSimulation/blob/master/README_files/UnityProject.png?raw=true)
1. 차량이 도로를 따라 움직이는 AI를 구현합니다.
2. 실제 도로에서 사용되고 있는 신호등의 신호 체계를 구현합니다.
3. 라즈베리파이, YOLOv5를 이용해 만든 최적의 신호등 알고리즘을 유니티에서 구현합니다.
4. 2번과 3번중 어느 것이 더 효율적인지 비교합니다.

## 2. 구현 목표
### 1. 신호등 동작 ✅
<details>
<summary>신호등 동작</summary>

<details>
<summary>구버전</summary>
<div>


<img src = "https://github.com/YunjinJo/TrafficSimulation/blob/master/README_files/plan1_1.png?raw=true" width="45%">   
<img src = "https://github.com/YunjinJo/TrafficSimulation/blob/master/README_files/plan1_2.png?raw=true" width="45%">   

정해진 시간에 따라 신호등의 신호가 자동으로 변경되는 것을 확인
</div>
</details>

<details>
<summary>신버전</summary>
<div>
<img src = "https://github.com/YunjinJo/TrafficSimulation/blob/master/README_files/TrafficLights_Image.png?raw=true" width="45%">   
</div>
</details>
</details>


### 2. 신호등 신호에 맞추어 차량 이동 ✅  
<details>
<summary>차량 이동</summary>

<details>
<summary>구버전</summary>
<div>

<img src = "https://github.com/YunjinJo/TrafficSimulation/blob/master/README_files/Plan2_gif.gif?raw=true">

<a href="https://www.youtube.com/watch?v=37I2fnLaaOU">유튜브 링크</a>

↑클릭시 유튜브로 이동  
신호등의 신호에 따라 차량이 멈추고, 움직이는 것을 확인
</div>
</details>

<details>
<summary>신버전</summary>
<div>
<img src = "https://github.com/YunjinJo/TrafficSimulation/blob/master/README_files/TrafficLights%20demo.gif?raw=true">
</div>
</details>


</details>

### 3. 2차로보다 더 큰 도로 만들기 
1. 도로 모델링 구하기  
2. Unity에서 marker, script설정  
3. 차량 동작 확인  


### 4. 보행자 구현
1. 보행자 모델링 구하기
   <img src = "https://github.com/YunjinJo/TrafficSimulation/blob/master/README_files/Human%20Modeling.png?raw=true">
   무료 사람 모델링 사용

2. 보행자 AI 구현
   <img src = "https://github.com/YunjinJo/TrafficSimulation/blob/master/README_files/Ped_Waypoint.png?raw=true">
   빨간색 Point로 보행자가 이동할 수 있는 장소를 미리 지정  
   신호등을 건너야 하는 경우 보행자 신호등에 따라 멈춤 or 이동  
   도착 지점은 사람이 스폰될 때 랜덤으로 지정됨, 최단 거리로 이동
3. 보행자 신호등 구현
  <img src = "https://github.com/YunjinJo/TrafficSimulation/blob/master/README_files/Ped_Lights.png?raw=true">
  차량용 신호등을 그대로 사용, 단 노란불은 작동하지 않음

### 5. 실제 지도 데이터 구현 -> 중단
1. 한국공학대학교 주변 도로 및 건물 구현
2. 보행자와 차량 자동 생성 및 이동 확인

### 6. 시뮬레이션 기능 추가
1. 차량 통행량 등 정보 시각화
   <img src = "https://github.com/YunjinJo/TrafficSimulation/blob/master/README_files/UI.png?raw=true">
   Timer : 시뮬레이션 작동 시간  
   CarCount : 신호등을 지나간 차량의 대수  
   Record : 60초마다 저장된 CarCount 값  
   Select TrafficLight : 각각의 신호등 동작 시간 변경  
   Save : Record 된 값들 CSV 파일로 저장  
   X2.5 : 버튼을 누르면 X0 (정지), X1 (1배속), X2.5 (2.5배속) 시뮬레이션 시간 조절  
   No AI : AI 기능이 없는 신호등 씬으로 변경  
   Exit : 프로그램 종료  

2. 데이터 저장  
   <img src = "https://github.com/YunjinJo/TrafficSimulation/blob/master/README_files/CSV%20Data.png?raw=true" width = "40%">  
   60초마다 저장된 데이터를 CSV 파일로 저장, 엑셀과 같은 프로그램으로 불러올 수 있음
 


## 3. 프로젝트 설치 방법
Releases에서 자신의 OS에 맞는 파일을 다운로드 후 실행시켜주세요.

## 4. 버전
- v0.2: 차량 AI, 신호등 동작 확인
- v0.3: 차량 AI, 신호등 연동, 2차선 도로 제작
- v0.4: SimpleTrafficSimulation 에셋 추가
- v0.5: 신호등 시뮬레이션 추가
- v0.6: 보행자 시뮬레이션 추가
- v0.7: UI 완성
- v0.8: 데이터 저장 기능 완성
- v1.0: 필수 기능 95% 완성
  (note: 씬 변환시 타이머 버그 있음)


## 5. 참고 자료
Simple City Builder: https://www.youtube.com/playlist?list=PLcRSafycjWFd6YOvRE3GQqURFpIxZpErI   
Adding people to city builder: https://www.youtube.com/watch?v=MpGfSbMikeQ&list=PLcRSafycjWFe50Nz4OBZC-5dYBKf3581v   
Traffic system in Unity 2020: https://www.youtube.com/watch?v=mu7f3Z1lRsE&list=PLcRSafycjWFdDou6OTCmGbRZ9lwLXjuMO   
