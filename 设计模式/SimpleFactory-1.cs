﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂模式
{
    public class RuleConfigSource
    {
        public RuleConfig load(String ruleConfigFilePath)
        {
            String ruleConfigFileExtension = getFileExtension(ruleConfigFilePath);
            IRuleConfigParser parser = RuleConfigParserFactory.createParser(ruleConfigFileExtension);
            
            String configText = "";
            //从ruleConfigFilePath文件中读取配置文本到configText中
            RuleConfig ruleConfig = parser.parse(configText);
            return ruleConfig;
        }

        private String getFileExtension(String filePath)
        {
            //...解析文件名获取扩展名，比如rule.json，返回json
            return "json";
        }
    }

    public class RuleConfig
    {
        public string  Name { get; set; }
    }
}
