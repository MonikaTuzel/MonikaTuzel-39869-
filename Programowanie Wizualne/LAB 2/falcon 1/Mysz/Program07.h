const char NazwaProgramu[] = "Program07";
const int MaxX = 400;
const int MaxY = 300;
void Rysuj(HDC hdc, int x, int y, int g)
{
	Ellipse(hdc, x-25-g, y-25-g, x+25+g, y+25+g);
	
}