'use client'

import { Button } from "@/src/app/components/ui/button";
import { Input } from "@/src/app/components/ui/input";
import { Label } from "@/src/app/components/ui/label"
import { SelectGroup, SelectLabel } from "@/src/app/components/ui/select";

import * as React from "react"

import { useState } from 'react';

/*import {
  Select,
  SelectContent,
  SelectItem,
  SelectTrigger,
  SelectValue,
} from "@/components/ui/select"*/


// Usar a funcao select depois
/*export function SelectLogin( {
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
}*/

import { createClient } from '@/src/lib/supabase/client'

export function GoogleLoginButton() {
  const supabase = createClient()

  const login = async () => {
    await supabase.auth.signInWithOAuth({
      provider: 'google',
      options: {
        redirectTo: `${location.origin}/auth/callback`,
      },
    })
  }

  return (
    <Button onClick={login}>
      Entrar com Google
    </Button>
  )
}


export const LoginForm = () => {
  const [email, setEmail] = useState("");
  const [senha, setSenha] = useState("");

  const onSubmit = (e: React.FormEvent) => {
      e.preventDefault();
      console.log(email, senha);
  }
    return (
      <form onSubmit={onSubmit} className="space-y-8 w-[400px]"> 
        <div className="grid w-full gap-1.5">
          <Label htmlFor="email">Email</Label>
          <Input
            id="email"
            type="email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
            required
          />

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
          {/*<Button type="submit">Login</Button>*/}
          <GoogleLoginButton />
        </div>
      </form>
    )
} 