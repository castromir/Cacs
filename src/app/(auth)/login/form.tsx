'use client'

import { Button } from "@/components/ui/button";
import { Input } from "@/components/ui/input";
import { Label } from "@/components/ui/label"
import * as React from "react"
import { CheckIcon, ChevronsUpDownIcon } from "lucide-react"
import { cn } from "@/lib/utils"

import {
  Command,
  CommandEmpty,
  CommandGroup,
  CommandInput,
  CommandItem,
  CommandList,
} from "@/components/ui/command"
import {
  Popover,
  PopoverContent,
  PopoverTrigger,
} from "@/components/ui/popover"

const users = [
  {
    value: "barto",
    label: "Bartô",
  },
  {
    value: "maite",
    label: "Maitê",
  },
  {
    value: "nyx",
    label: "Nyx",
  },
  {
    value: "oscar",
    label: "Oscar",
  },
  {
    value: "rogerio",
    label: "Rogério",
  },
  {
    value: "xavier",
    label: "Xavier",
  },
]

export function LoginCombobox() {
  const [open, setOpen] = React.useState(false)
  const [value, setValue] = React.useState("")
  return (
    <Popover open={open} onOpenChange={setOpen}>
      <PopoverTrigger asChild>
        <Button
          variant="outline"
          role="combobox"
          aria-expanded={open}
          className="w-full justify-between"
        >
          {value
            ? users.find((user) => user.value === value)?.label
            : "Selecione o usuário..."}
          <ChevronsUpDownIcon className="ml-2 h-4 w-4 shrink-0 opacity-50" />
        </Button>
      </PopoverTrigger>
      <PopoverContent className="w-[--radix-popover-trigger-width] p-0">
        <Command>
          <CommandInput placeholder="Pesquisar usuário..." />
          <CommandList>
            <CommandEmpty>Nenhum usuário encontrado.</CommandEmpty>
            <CommandGroup>
              {users.map((user) => (
                <CommandItem
                  key={user.value}
                  value={user.value}
                  onSelect={(currentValue) => {
                    setValue(currentValue === value ? "" : currentValue)
                    setOpen(false)
                  }}
                >
                  <CheckIcon
                    className={cn(
                      "mr-2 h-4 w-4",
                      value === user.value ? "opacity-100" : "opacity-0"
                    )}
                  />
                  {user.label}
                </CommandItem>
              ))}
            </CommandGroup>
          </CommandList>
        </Command>
      </PopoverContent>
    </Popover>
  )
}

export const LoginForm = () => {
    const onSubmit = (e: React.FormEvent) => {
        e.preventDefault();
        console.log('Login!');
    }
    return (
        <form className="space-y-8 w-[400px]"> 
            <div className="grid w-full gap-1.5">
                <Label htmlFor="email">Usuário</Label>
                <LoginCombobox />
            </div>

            <div className="grid w-full items-center gap-1.5">
                <Label htmlFor="senha">Senha</Label>
                <Input id="senha" type="senha" required />
            </div> 

            <div className="grid w-full items-center">
                <Button>Login</Button>  
            </div>
        </form>
    )
}