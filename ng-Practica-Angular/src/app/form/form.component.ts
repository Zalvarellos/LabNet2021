import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.scss']
})
export class FormComponent implements OnInit {

  form!: FormGroup;

  constructor(private readonly fb: FormBuilder) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      nombre: [''],
      descripcion: ['']
    });
  }

  onSubmit(): void {
    console.log(this.form.value);
  }

  onClickLimpiar(): void {
    const nombreCtrl = this.form.get('nombre');
    const descripcionCtrl = this.form.get('descripcion');
    if (nombreCtrl) {
      nombreCtrl.setValue('');
    }
    if (descripcionCtrl) {
      descripcionCtrl.setValue('');
    }
  }
}
