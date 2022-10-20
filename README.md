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
2. 보행자 AI 구현
3. 보행자 신호등 구현
4. 보행자 횡단보도 구현
5. 보행자와 차량간 AI 연동

### 5. 실제 지도 데이터 구현
1. 한국공학대학교 주변 도로 및 건물 구현
2. 보행자와 차량 자동 생성 및 이동 확인

### 6. 시뮬레이션 기능 추가
1. 특정 지역의 차량 대수, 차량 통행량 등 정보 시각화


## 3. 프로젝트 설치 방법
Releases에서 자신의 OS에 맞는 파일을 다운로드 후 실행시켜주세요.

## 4. 버전
- v0.2: 차량 AI, 신호등 동작 확인
- v0.3: 차량 AI, 신호등 연동, 2차선 도로 제작
- v0.4: SimpleTrafficSimulation 에셋 추가


## 5. 참고 자료
Simple City Builder: https://www.youtube.com/playlist?list=PLcRSafycjWFd6YOvRE3GQqURFpIxZpErI   
Adding people to city builder: https://www.youtube.com/watch?v=MpGfSbMikeQ&list=PLcRSafycjWFe50Nz4OBZC-5dYBKf3581v   
Traffic system in Unity 2020: https://www.youtube.com/watch?v=mu7f3Z1lRsE&list=PLcRSafycjWFdDou6OTCmGbRZ9lwLXjuMO   
