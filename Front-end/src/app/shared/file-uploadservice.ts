import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class FileUploadService{

  constructor(private http: HttpClient) { }
  readonly baseUrl = `https://localhost:44386/api/FileUpload`;
  fileContent: string='';

   public postFileString(fileList: FileList): void {
    let file = fileList[0];
    let fileReader: FileReader = new FileReader();
    let self = this;
    fileReader.onloadend = function(x) {
      self.fileContent = fileReader.result as string;
      return self.http.post(self.baseUrl, self.fileContent);
    }
  }
}
