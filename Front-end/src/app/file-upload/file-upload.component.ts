import { HttpClient } from '@angular/common/http';
import { Component} from '@angular/core';
import { FileUploadService } from '../shared/file-uploadservice';

@Component({
  selector: 'app-file-upload',
  templateUrl: './file-upload.component.html',
  styleUrls: ['./file-upload.component.css']
})
export class FileUploadComponent  {

  constructor(private http: HttpClient) { }
  readonly baseUrl = `https://localhost:44386/api/FileUpload`;
  fileContent: string='';

   public postFileString(fileList: FileList): void {
    let file = fileList[0];
    let fileReader: FileReader = new FileReader();
    let self = this;
    fileReader.onloadend = function(x) {
      self.fileContent = fileReader.result as string;
      console.log('Gelukt');
      return self.http.post(self.baseUrl, self.fileContent, {responseType: 'text'}).subscribe();
    }
    fileReader.readAsText(file);
  } 

}

