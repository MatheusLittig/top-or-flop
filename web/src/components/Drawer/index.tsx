import React from 'react'

import {
  Box,
  Flex,
  Image,
  List,
  ListItem,
  Text,
  Avatar
} from '@chakra-ui/react'

import { menuOptions, accountOptions, userData } from './constants'

import Divider from '../Divider'

const Drawer: React.FC = () => {
  return (
    <Flex
      pt={6}
      pb={6}
      pl={8}
      pr={8}
      flexDir="column"
      align="flex-start"
      w="100%"
      h="100%"
    >
      <Image src="cytrus.svg" alt="Cytrus Project" w={180} />

      <Flex
        flexDir="column"
        align="flex-start"
        w="100%"
        h="100%"
        justify="space-between"
        mt={8}
      >
        <List spacing={2} w="100%">
          {menuOptions.map(option => (
            <ListItem padding={4} _hover={{ bg: 'gray.500' }} key={option.id}>
              <Text as="h2" fontWeight="bold">
                {option.title}
              </Text>
            </ListItem>
          ))}

          <Divider title="Account" />

          {accountOptions.map(option => (
            <ListItem padding={4} _hover={{ bg: 'gray.500' }} key={option.id}>
              <Text as="h2" fontWeight="bold">
                {option.title}
              </Text>
            </ListItem>
          ))}
        </List>

        <Flex as="section">
          <Avatar name={userData.name} src={userData.picture} mr={4} />
          <Box>
            <Text as="h3" fontWeight="bold">
              @{userData.name}
            </Text>
            <Text as="p">@{userData.nickname}</Text>
          </Box>
        </Flex>
      </Flex>
    </Flex>
  )
}

export default Drawer
