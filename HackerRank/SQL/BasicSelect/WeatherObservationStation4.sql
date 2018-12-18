/* <summary>
This is the solution only, for implementation and test cases view the below URL
https://www.hackerrank.com/challenges/weather-observation-station-4/problem
</summary>*/
SELECT COUNT(CITY) - COUNT(DISTINCT CITY) FROM STATION;