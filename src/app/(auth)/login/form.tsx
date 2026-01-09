'use client'

import { Button } from "@/components/ui/button";
import { Input } from "@/components/ui/input";
import { Label } from "@/components/ui/label"
import { SelectGroup, SelectLabel } from "@/components/ui/select";

import * as React from "react"

import { useState } from 'react';

import {
  Select,
  SelectContent,
  SelectItem,
  SelectTrigger,
  SelectValue,
} from "@/components/ui/select"

export function SelectLogin( {
    value,
  onChange,
}: {
  value: string;
  onChange: (value: string) => void;
}) {
  
  return (
    <Select value={value} onValueChange={onChange}>
      <SelectTrigger className="w-full justify-between">
        <SelectValue placeholder="Selecione o usuário" />
      </SelectTrigger>
      <SelectContent>
        <SelectGroup>
          <SelectLabel>Usuários</SelectLabel>
          <SelectItem value="barto">Bartô</SelectItem>
          <SelectItem value="maite">Maitê</SelectItem>
          <SelectItem value="nyx">Nyx</SelectItem>
          <SelectItem value="rogerio">Rogério</SelectItem>
          <SelectItem value="xavier">Xavier</SelectItem>
        </SelectGroup>
      </SelectContent>
    </Select>
  )
}


export const LoginForm = () => {
  const [usuario, setUsuario] = useState("");
  const [senha, setSenha] = useState("");

  const onSubmit = (e: React.FormEvent) => {
      e.preventDefault();
      console.log(usuario, senha);
  }
    return (
      <form onSubmit={onSubmit} className="space-y-8 w-[400px]"> 
        <div className="grid w-full gap-1.5">
          <Label htmlFor="usuario">Usuário</Label>
          <SelectLogin value={usuario} onChange={setUsuario}/>
        </div>

        <div className="grid w-full items-center gap-1.5">
          <Label htmlFor="senha">Senha</Label>
          <Input
            id="senha"
            type="password"
            value={senha}
            onChange={(e) => setSenha(e.target.value)}
            required
          />
        </div> 

        <div className="grid w-full items-center">
          <Button>Login</Button>  
        </div>
      </form>
    )
}