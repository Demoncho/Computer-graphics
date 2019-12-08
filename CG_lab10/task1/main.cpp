#include <C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\include\GL\glut.h>
#include <C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\include\GL\freeglut.h>
#include <windows.h>

float rotate_x = 0, rotate_y = 0, rotate_z = 0;
int idFigure = 0;
float R = 1, G = 1, B = 1;

void randomColor()
{
	R = (rand() % 255) / 255.0;
	G = (rand() % 255) / 255.0;
	B = (rand() % 255) / 255.0;
}

void triangle()
{
	glBegin(GL_TRIANGLES);
	glVertex2f(-0.5f, -0.5f);
	glVertex2f(0.f, 0.5f);
	glVertex2f(0.5f, -0.5f);
	glEnd();
}

void triangleDifCol()
{
	glBegin(GL_TRIANGLES);
	GLfloat BlueCol[3] = { 0 , 0 , 1 };
	glColor3f(1.f, 0.f, 0.f);
	glVertex2f(-0.5f, -0.5f);
	glColor3ub(0, 255, 0);
	glVertex2f(0.f, 0.5f);
	glColor3fv(BlueCol);
	glVertex2f(0.5f, -0.5f);
	glEnd();
}

void rectangle()
{
	glBegin(GL_QUADS);
	glVertex2f(-0.6f, -0.5f);
	glVertex2f(-0.6f, 0.5f);
	glVertex2f(0.6f, 0.5f);
	glVertex2f(0.6f, -0.5f);
	glEnd();
}

void drawFigure(int n) {
	switch (n)
	{
	case 0:
		glutWireCube(0.5f);
		break;
	case 1: 
		triangle(); 
		break;
	case 2: 
		triangleDifCol(); 
		break;
	case 3: 
		rectangle(); 
		break;
	}
}

void specialKeys(int key, int x, int y)
{
	switch (key)
	{
	case GLUT_KEY_UP: rotate_x += 5; break;
	case GLUT_KEY_DOWN: rotate_x -= 5; break;
	case GLUT_KEY_LEFT: rotate_y += 5; break;
	case GLUT_KEY_RIGHT: rotate_y -= 5; break;
	case GLUT_KEY_PAGE_UP: rotate_z += 5; break;
	case GLUT_KEY_PAGE_DOWN: rotate_z -= 5; break;
	default:
		break;
	}
	glutPostRedisplay();
}

void mouseKeys(int button, int state, int x, int y)
{
	if (button == GLUT_LEFT_BUTTON)
	{
		randomColor();
		idFigure = 1 + rand() % 3;
	}
}

void renderFigure() {
	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
	glClearColor(0.0f, 0.0f, 0.0f, 0.0f);

	glRotatef(rotate_x, 1, 0, 0);
	glRotatef(rotate_y, 0, 1, 0);
	glRotatef(rotate_z, 0, 0, 1);

	glColor3f(R, G, B);

	drawFigure(idFigure);

	glLoadIdentity();
	glutSwapBuffers();
}


int main(int argc, char** argv) {
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_RGBA | GLUT_DOUBLE);
	glutInitWindowPosition(100, 100);
	glutInitWindowSize(800, 600);
	glutCreateWindow("Lab10 task1");

	glutDisplayFunc(renderFigure);
	glutSpecialFunc(specialKeys);
	glutMouseFunc(mouseKeys);

	glutMainLoop();
	return 0;
}