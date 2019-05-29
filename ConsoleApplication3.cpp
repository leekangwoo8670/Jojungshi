#include <stdio.h>
#include <string.h>

#define buffsize 10

int main()
{
	FILE *in, *out;
	double i=0;

	fopen_s(&in, "C:/Users/admin/Downloads/aaa.txt", "r");
	fopen_s(&out, "C:/Users/admin/Downloads/test.txt", "w");
		
	char buff[buffsize+1];

	while (!feof(in)) {
		memset(buff, 0x00, sizeof(buff));
		fread(buff, 1, buffsize, in);
		fwrite(buff,1, buffsize, out);
		
		printf("Buff = %s\n", buff);

		i++;
	}

	printf("Count = %lf", i);

	fclose(in);
	fclose(out);
}
