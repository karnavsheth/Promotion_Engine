# Promotion Engine

This is a simple console application which will help you get final price of container cart for logistic business. Cart contains a list of single character SKU ids (A, B, C....) over which the promotion engine will need to run. </br>
The promotion engine will need to calculate the total order value after applying the 2 promotion types
<ul>
  <li>buy 'n' items of a SKU for a fixed price (3 A's for 130)</li>
  <li>buy SKU 1 & SKU 2 for a fixed price ( C + D = 30 )</li>
</ul>
The code is enough extensible to add any new type of promotional type in future. we are assuming here that, the promotions will be mutually exclusive; in other words if one is applied the other promotions will not apply.
</br></br>
<b>Test Setup: </b></br>
Unit price for SKU IDs</br>
A      50</br>
B      30</br>
C      20</br>
D      15</br>
</br>
<b>Active Promotions: </b></br>
3 of A's for 130</br>
2 of B's for 45</br>
C & D for 30</br>

</br>
For extensibilty stand point, Strategy Design pattern is being used.

![image](https://user-images.githubusercontent.com/25846337/137758306-9774bd1f-efbf-4354-bab4-1a21006aabf3.png)

![image](https://user-images.githubusercontent.com/25846337/137758419-aa31e5c3-d69a-4da3-bc94-5053930a40a2.png)
