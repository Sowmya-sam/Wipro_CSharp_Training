1.   Write algorithm and pseudo code the following requirement:
	a.   Find out simple interest calculation based on the given inputs.
-------------------------------------------------------------------
	Requirement: Finding out SIMPLE INTEREST CALCULATION

Phase-1 : Algorithm
~~~~~~~~

1. Start by giving Inputs.
2. Calculate Simple Interest with Formula: SI = (P*T*R)/100
3. Print Result.

Phase-2 : Pseudo-Code
````````

	Input P, T, R
	SI = (P*T*R)/100
	Print SI

----------------------------------------------------------------
2. Write algorithm and pseudo code the following requirement:
	
		a.  Check the given number is prime number or not 
		b.  Display 5 multiples that are less than 100
		c.   Find out how many even numbers and odd numbers  in the given array	
----------------------------------------------------------------
		Requirement: Finding out even & odd numbers

2a. Phase-1: Algorithm
~~~~~~~~~~~~

1. Start with an Input.
2. If input<2, it is not a prime number.
3. Check divisibilty of 2 with the input, if the input is divisble by any number in this range it is not a prime. 
4. Otherwise, it is a prime.
5. Print out the result whether it is prime or not.

Phase-2: Pseudo-Code

if (n < 2)
	print "Not a prime"
else
	isPrime = true
	for i from 2 to sqrt(n)
		if n % i ==0
			isprime = false
	if isPrime
		Print "It is a Prime"
	else
		Print "Not a Prime"
-------------------------------------------------

2b. REQUIREMENT: Display 5 multiples less than 100

Phase-1: Algorithm
~~~~~~~~

1. Give input as 0.
2. Initialize a counter 
3. Looping through the numbers starting from 5
4. Check for each multiple of 5, check if it is less than 100 and count it
5. Print the output multiples of 5.

Phase-2: Pseudo-Code
~~~~~~~~`

count=0
for i from 5 to 100 step 5
	print i
	count = count+1
	if count == 5
-------------------------------------------------
2c. Count even & Odd numbers in an Array

Phase-1: Algorithm
~~~~~~~

1. Initialize counter for even & odd numbers
2. Loop through each element in the array.
3. Check if the element is even or odd and increment the counter.
4. print the number of even & odd numbers.

Phase-2: Pseudo- Code
~~~~~~~~

eCount = 0 
oCount = 0
 
for each number in arr
	if number % 2 == 0
		eCount = eCount + 1
	else
		oCount = oCount + 1
Print eCount, oCount
-------------------------------------------------

3. Requirement: Login Attempts

Phase-1: Algorithm
~~~~~~~~

1. Initialize counter for attempts
2. Loop until the max number of attempts it reached.
3. Prompt the user for Uname and Password
4. Check if Uname and Password are correct
5. If correct print success and exit the loop
6. If not, increment the attempt counter and print error
7. If maximum number of attempts is reached, lock the account
8. Print whether it is success or failure.

Phase-2: Pseudo-Code
~~~~~~~~

attempts=0
maxAttempts=3
while attempts < maxAttempts
	uname = Input("Enter username: ")
	password = Input("Enter passwors: ")
	
	if uname == "correctUsername" and password == "correctPassword"
		print "Login Success"
	else
		attempts = attempts+1
		print "Invalid username or password" + attempts + "of" + maxAttempts

if attempts == maxAttempts
	print" Too many attempts, please try after some time"









