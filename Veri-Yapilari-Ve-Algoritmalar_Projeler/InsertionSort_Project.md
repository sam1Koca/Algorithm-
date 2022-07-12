## Proje 1

<h4><a href="https://app.patika.dev/sayitsami">My Patika Dev Account<a/></h4>

  
---
### [22,27,16,2,18,6] -> Insertion Sort
---

## <b>1- Yukarı verilen dizinin sort türüne göre aşamalarını yazınız.<br/></b>
<p><b>🎗️ Insertion Sort'un ne yaptığını hatırlayalım:<b><br/>
  - Verilen örüntüye ait en küçük elemanı buluyor ve en baştaki sayı ile yer değiştiriyor.<br/><p>
  
  ```
    * [22,27,16,2,18,6] =>  n
    * [2,27,16,22,18,6] => (n-1)
    * [2,6,16,22,18,27] => (n-2)
    * [2,6,16,18,22,27] => (n-3)
  ```
<br/>
  
## <b>2- Big-O gösterimini yazınız.<br/></b>
 🎗️ Big-O-Nation Nedir:<br/>
 - Yazılan bir algoritmanın performansını ölçebilmemiz için kullanacağımız en önemli araçlardan biridir.
 - Big-O notation bir algoritmanın performansını veya time complexity’sini hesaplamak için kullanılır.
  
```
  
- Big-O : O(n²)
  
```

<br/>
  
## 3- Time Complexity
🎗️ Time Complexity Nedir:<br/>
 - Time complexity bir algoritmanın çalışması için gerekli olan süredir.
<br/>
Best case: Aradığımız sayının dizinin en başında olması.

   ### Best case : O(n)
<br/>
Average case: Aradığımız sayının ortada olması.

   ### Average case : O(n²)
<br/>
Worst case: Aradığımız sayının sonda olması.

   ### Worst case : O(n²)
  
<br>
  
## 4- Dizi sıralandıktan sonra 18 sayısı hangi case kapsamına girer? Yazınız.
  
```
   18 sayısı ortalarda olduğu için Average Case kapsamına girmektedir.
```
  
<br/>
  
## 5- [7,3,5,8,2,9,4,15,6] dizisinin Insertion Sort'a göre ilk 4 adımını yazınız.

    - [2,3,5,8,7,9,4,15,6]
  
    - [2,3,4,8,7,9,5,15,6]
  
    - [2,3,4,5,7,9,8,15,6]
  
    - [2,3,4,5,6,9,8,15,7]
