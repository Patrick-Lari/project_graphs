//Array of Objects

const quiz = [

	/*Question_1*/
	{
		q: 'Care dintre următoarele afirmații sunt corecte?',
		options: ['Într-un graf neorientat o muchie poate fi adiacentă cu un vârf.', 
				'Într-un graf neorientat două muchii pot fi adiacente.', 
				'Într-un graf neorientat o muchie poate fi incidentă cu un vârf.', 
				'Într-un graf neorientat două vârfuri pot fi incidente.'],
		answer: 2
	},

	/*Question_2*/
	{
		q: 'Se consideră un graf neorientat cu 50 noduri şi 32 muchii. Care este numărul maxim de vârfuri cu gradul 0 pe care le poate avea graful?',
		options: ['45', 
				'40', 
				'41', 
				'50'],
		answer: 2
	},

	/*Question_3*/
	{
		q: 'Dacă n este un număr natural impar mai mare decât 2, atunci un graf neorientat cu n noduri, în care fiecare nod este adiacent cu exact n-1 noduri, este întotdeauna:',
		options: ['arbore', 
				'graf eulerian', 
				'graf neconex', 
				'graf aciclic'],
		answer: 1
	},

	/*Question_4*/
	{
		q: 'Un graf neorientat cu 8 noduri are gradele nodurilor egale cu 1, 2, 4, 2, 3, 2, 1, x. Pentru ce valoare a lui x graful este arbore?',
		options: ['x = 1', 
				'x < 3', 
				'x > 3', 
				'nicio valoare'],
		answer: 3
	},

	/*Question_5*/
	{
		q: 'Care este numărul maxim de noduri de grad 3 într-un graf neorientat cu 5 noduri?',
		options: ['4', 
				'5', 
				'3', 
				'2'],
		answer: 0
	},
	
	/*Question_6*/
	{
		q: 'Se consideră un graf neorientat cu 5 noduri şi 9 muchii. Care dintre următoarele şiruri de numere poate fi şirul gradelor nodurilor grafului?',
		options: ['4, 2, 6, 4, 2', 
				'2, 2, 1, 2, 2', 
				'1, 1, 1, 1, 1', 
				'4, 3, 3, 4, 4'],
		answer: 3
	},

	/*Question_7*/
	{
		q: 'Care este numărul maxim de muchii pe care-l poate avea un graf neorientat cu 6 noduri, care nu este conex?',
		options: ['4', 
				'15', 
				'12', 
				'10'],
		answer: 3
	},

	/*Question_8*/
	{
		q: 'Care dintre următoarele afirmaţii este adevărată pentru orice graf neorientat G cu 5 noduri şi 6 muchii?',
		options: ['G are cel puţin un ciclu', 
				'G este conex', 
				'G are gradele tuturor nodurilor numere pare', 
				'G nu poate avea noduri cu gradul 0'],
		answer: 0
	},

	/*Question_9*/
	{
		q: 'Fie n un număr natural, n>4. Orice graf neorientat cu n noduri şi n muchii:',
		options: ['are gradele tuturor nodurilor numere pare', 
				'este conex', 
				'are cel puţin un ciclu', 
				'este arbore'],
		answer: 2
	}
]